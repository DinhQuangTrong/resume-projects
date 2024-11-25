from django.shortcuts import render,redirect
from django.http import HttpResponse, JsonResponse
from .models import *
import json

#Form tự tạo trong Django
from django.contrib.auth.forms import UserCreationForm
# Xác thực
from django.contrib.auth import authenticate,login,logout
#Thông báo
from django.contrib import messages

#Để nó hiện lên thì cần thêm: categories = Category.objects.filter(is_sub = False) Vào trang mình muốn nó hiện (def)
def category(request):
    # lấy danh mục con: categories = Category.objects.filter(is_sub = True)
    categories = Category.objects.filter(is_sub = False)
    active_category = request.GET.get('category','')
    if active_category:
        products = Product.objects.filter(category__slug = active_category)
    context = {'categories':categories,'products':products,'active_category':active_category}
    return render(request,'app/category.html',context)

def search(request):
    if request.method == "POST":
        searched = request.POST["searched"]
        # Lọc
        keys = Product.objects.filter(name__contains = searched)
    if request.user.is_authenticated:
        #  chỉ dừng ở user thôi: customer = request.user.customer
        customer = request.user
        order, created = Order.objects.get_or_create(customer=customer, complete=False)
        items = order.orderitem_set.all()
        cartItems = order.get_cart_items
    else:
        items=[] 
        order = {'get_cart_items':0,'get_cart_total':0 }  
        cartItems = order['get_cart_items']   
    products = Product.objects.all()
    # Không cần cũng được : context= {'products': products,'cartItems':cartItems}
    return render(request, 'app/search.html',{"searched":searched,"keys":keys,'products': products,'cartItems':cartItems})

def register(request):
    #Form tự tạo
    # form mặc định :form = UserCreationForm()
    
    #Mới
    form = CreateUserForm()
    
    if request.method == "POST":
        #mặc định form = UserCreationForm(request.POST)
        form = CreateUserForm(request.POST)
        #thõa mãn tất cả đk rồi
        if form.is_valid():
            form.save()
            # Sau khi đăng ký thì nó đơ, để nó load luôn sang login thì dùng
            return redirect('login')
    # Nội dung
    context = {'form':form}
    return render(request,'app/register.html',context)

def loginPage(request):
    #Đã đăng nhập từ trước
    if request.user.is_authenticated:
        #Trỏ về
        return redirect('home')
    if request.method == "POST":
        #Lấy từ name="username" trong login.html
        username = request.POST.get('username')
        password = request.POST.get('password')
        #Kiểm tra
        user = authenticate(request,username=username,password=password)
        #Không nhập, nhập sai
        if user is not None:
            login(request,user)
            return redirect('home')
        else: messages.info(request,'user or password not correct!')
        
    # Nội dung
    context = {}
    return render(request,'app/login.html',context)

def logoutPage(request):
    logout(request)
    return redirect('login')

def home(request):
    # Xác thực và nếu đã đăng nhập thì có thể mua tăng
    if request.user.is_authenticated:
        #  chỉ dừng ở user thôi: customer = request.user.customer
        customer = request.user
        order, created = Order.objects.get_or_create(customer=customer, complete=False)
        items = order.orderitem_set.all()
        cartItems = order.get_cart_items
        # user_not_login = "hidden"
        # user_login = "show"
    else:
        items=[] 
        order = {'get_cart_items':0,'get_cart_total':0 }  
        cartItems = order['get_cart_items'] 
        # user_not_login = "show"
        # user_login = "hidden"  
    categories = Category.objects.filter(is_sub = False)
    products = Product.objects.all()
    # context= {'products': products,'cartItems':cartItems,'user_not_login':user_not_login,'user_login':user_login}
    context= {'categories':categories,'products': products,'cartItems':cartItems}
    #return render(request, 'app/base.html')
    return render(request, 'app/home.html', context)

def cart(request):
    if request.user.is_authenticated:
        # customer = request.user.customer
        customer = request.user
        order, created = Order.objects.get_or_create(customer=customer, complete=False)
        items = order.orderitem_set.all()
        cartItems = order.get_cart_items
        # user_not_login = "hidden"
        # user_login = "show"
    else:
        items=[] 
        order = {'get_cart_items':0,'get_cart_total':0 }
        cartItems = order['get_cart_items']  
        # user_not_login = "show"
        # user_login = "hidden"
    context= {'items':items,'order':order, 'cartItems':cartItems}  
    return render(request, 'app/cart.html',context)

def checkout(request):
    if request.user.is_authenticated:
        # customer = request.user.customer
        customer = request.user
        order, created = Order.objects.get_or_create(customer=customer, complete=False)
        items = order.orderitem_set.all()
        cartItems = order.get_cart_items
    else:
        items=[] 
        order = {'get_cart_items':0,'get_cart_total':0 }
        cartItems = order['get_cart_items']  
    context= {'items':items,'order':order, 'cartItems':cartItems}  
    return render(request, 'app/checkout.html',context)

def updateItem(request):
    data = json.loads(request.body)
    productId = data['productId']
    action = data['action']
    # customer = request.user.customer
    customer = request.user
    product = Product.objects.get(id = productId)
    order, created = Order.objects.get_or_create(customer=customer, complete=False)
    orderItem, created = OrderItem.objects.get_or_create(order= order, product=product)
    if action == 'add':
        orderItem.quantity +=1
    elif action == 'remove':
        orderItem.quantity -= 1
    orderItem.save()
    if orderItem.quantity <= 0:
        orderItem.delete()
        
    return  JsonResponse('added', safe=False)