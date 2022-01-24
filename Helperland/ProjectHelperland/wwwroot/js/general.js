window.addEventListener("scroll", () => {
	let nav = document.querySelector("nav");
	let winPos = window.scrollY > 0;

	nav.classList.toggle("scroll-active", winPos);
	btnHome.classList.toggle("b2h-btn", winPos);
});

jQuery('.ok-btn').click(function(e){
		e.preventDefault();
		var _this = jQuery(this);
		_this.closest('.footer-bottom').slideUp();

})

$(document).on('click','ul .nav-item',function(){
	$(this).addClass('active').siblings().removeClass('active')
})