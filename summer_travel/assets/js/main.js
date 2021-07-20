var index = 0;
nextImage = function(){
    var imgs = ["./assets/img/parallax-9.jpg","./assets/img/parallax-4-1.jpg","./assets/img/parallax-4.jpg"];
    document.getElementById('img').src = imgs[index];
    index++;
    if(index==3){
        index = 0;
    }
}
setInterval(nextImage,3000)
