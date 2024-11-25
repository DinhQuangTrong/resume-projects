from django.db import models
from django.contrib.auth.models import User
#Form tự tạo trong Django
from django.contrib.auth.forms import UserCreationForm

# Create your models here.

class Category(models.Model):
    sub_category = models.ForeignKey('self',on_delete=models.CASCADE, related_name='sub_categories',null=True,blank=True)
    #Có phải danh mục con không
    is_sub = models.BooleanField(default=False)
    name = models.CharField(max_length=200,null=True)
    #Tối ưu đường dẫn
    slug = models.SlugField(max_length=200, unique=True)
    def __str__(self):
        return self.name

#Thay form register django
#kế thừa
class CreateUserForm(UserCreationForm):
    class Meta:
        model = User
        #Các trường có sẵn phải gõ đúng
        fields = ['username','email','first_name','last_name','password1','password2']

#dùng sqlite
#Tạo bảng
# Không cần customer lấy luôn của User
# class Customer(models.Model):
#     user= models.OneToOneField(User ,on_delete=models.SET_NULL,null=True,blank=False)
#     name = models.CharField(max_length=200,null=True)
#     email = models.CharField(max_length=200,null=True)
    
#     def __str__(self):
#         return self.name
    
class Product(models.Model):
    category = models.ManyToManyField(Category,related_name='product')
    name = models.CharField(max_length=200,null=True)
    price = models.FloatField()
    digital = models.BooleanField(default=False,null=True,blank=False)
    image = models.ImageField(null=True,blank=True)
    
    def __str__(self):
        return self.name
    
    #Điều chỉnh thuộc tính Ảnh khi thiếu ảnh và gặp lỗi
    @property
    def ImageURL(self):
        try:
            url = self.image.url
        except:
            url = ''
        return url
    
class Order(models.Model):
    # customer = models.ForeignKey(Customer,on_delete=models.SET_NULL,blank=True,null=True)
    customer = models.ForeignKey(User,on_delete=models.SET_NULL,blank=True,null=True)
    date_order = models.DateTimeField(auto_now_add=True)
    complete = models.BooleanField(default=False,null=True,blank=True)
    transaction_id = models.CharField(max_length=200,null=True)
    
    def __str__(self):
        return str(self.id)
    
    #Đếm số lượng sản phẩm
    @property
    def get_cart_items(self):
        orderitems = self.orderitem_set.all()
        total = sum([item.quantity for item in orderitems])
        return total
    
    #Tổng
    @property
    def get_cart_total(self):
        orderitems = self.orderitem_set.all()
        total = sum([item.get_total for item in orderitems])
        return total

    
class OrderItem(models.Model):
    product = models.ForeignKey(Product,on_delete=models.SET_NULL,blank=True,null=True)
    order = models.ForeignKey(Order,on_delete=models.SET_NULL,blank=True,null=True)
    quantity = models.IntegerField(default=False,null=True,blank=True)
    date_added = models.DateTimeField(auto_now_add=True)
   
   #Tính tổng tiền
    @property
    def get_total(self):
        total = self.product.price * self.quantity
        return total
    
class ShippingAddress(models.Model):
    # customer = models.ForeignKey(Customer,on_delete=models.SET_NULL,blank=True,null=True)
    customer = models.ForeignKey(User,on_delete=models.SET_NULL,blank=True,null=True)
    order = models.ForeignKey(Order,on_delete=models.SET_NULL,blank=True,null=True)
    address = models.CharField(max_length=200,null=True)
    city = models.CharField(max_length=200,null=True)
    state = models.CharField(max_length=200,null=True)
    mobile = models.CharField(max_length=10,null=True)
    date_added = models.DateTimeField(auto_now_add=True)
    
    def __str__(self):
        return self.address