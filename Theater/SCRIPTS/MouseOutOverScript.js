function ImgMouseOverForAll(s)
{
	document.getElementById(s).width = document.getElementById(s).width + 10;
	document.getElementById(s).height = document.getElementById(s).height + 5;
}

function ImgMouseOutForAll(s)
{
	document.getElementById(s).width = document.getElementById(s).width - 10;
	document.getElementById(s).height = document.getElementById(s).height - 5;
}

