var updateBtns = document.getElementsByClassName('update-cart')

for(i=0;i < updateBtns.length;i++){
    updateBtns[i].addEventListener('click',function(){
        var productId = this.dataset.product
        var action = this.dataset.action
        console.log('productId',productId, 'action',action)

        /**Tài khoản nào đã đăng nhập */
        console.log('user:',user)
        if (user === "AnonymousUser"){
            console.log('user chưa đăng nhập')
        }else{
            updateUserOrder(productId,action)
        }
    })
}

function updateUserOrder(productId,action){
    console.log('user đã đăng nhập, add success')
    var url = '/update_item/'
    /**Bóc tách */
    fetch(url,{
        method:'POST',
        headers:{
            'ContentType':'application/json',
            /**Sửa lỗi token: xóa*/
            'X-CSRFToken':csrftoken,
        },
        /**'productId' vẫn là biến nên đừng có khoảng trắng*/
        body: JSON.stringify({'productId':productId,'action':action})
    })
    .then((response) =>{
        return response.json()
    })
    /**xem đã đưa gì vào giỏ hàng */
    .then((data) =>{
        console.log('data',data)

        /**Tự động refresh */
        location.reload()
    })
}