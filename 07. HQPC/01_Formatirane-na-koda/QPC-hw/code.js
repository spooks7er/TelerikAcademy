var navAppName = navigator.appName,
    addScroll = false,
    off = 0,
    txt = "",
    pX = 0,
    pY = 0,
    document.onmousemove = mouseMove;

if (navigator.userAgent.indexOf('MSIE 5') ||
    navigator.userAgent.indexOf('MSIE 6')) {
    addScroll = true;
}

if (navAppName === "Netscape") {
    document.captureEvents(event.mousemove)
};

function mouseMove(evn) {
    if (navAppName === "Netscape") {
        pX = evn.pageX - 5;
        pY = evn.pageY;
    } else {
        pX = event.x - 5;
        pY = event.y;
    }

    if (navAppName === "Netscape") {
        if (document.layers['ToolTip'].visibility === 'show') {
            popTip();
        }
    } else {
        if (document.all['ToolTip'].style.visibility === 'visible') {
            popTip();
        }
    }
}

function popTip() {
    if (navAppName === "Netscape") {
        currentLayer = eval('document.layers[\'ToolTip\']');

        if ((pX + 120) > window.innerWidth) {
            pX = window.innerWidth - 150;
        }

        currentLayer.left = pX + 10;
        currentLayer.top = pY + 15;
        currentLayer.visibility = 'show';
    } else {
        currentLayer = eval('document.all[\'ToolTip\']');
        
        if (currentLayer) {
            pX = event.x - 5;
            pY = event.y;

            if (addScroll) {
                pX = pX + document.body.scrollLeft;
                pY = pY + document.body.scrollTop;
            }

            if ((pX + 120) > document.body.clientWidth) {
                pX = pX - 150;
            }

            currentLayer.style.pixelLeft = pX + 10;
            currentLayer.style.pixelTop = pY + 15;
            currentLayer.style.visibility = 'visible';
        }
    }
}

function hideTip() {
    args = hideTip.arguments;

    if (navAppName === "Netscape") {
        document.layers['ToolTip'].visibility = 'hide';
    } else {
        document.all['ToolTip'].style.visibility = 'hidden';
    }
}

function HideMenu1() {
    if (navAppName === "Netscape") {
        document.layers['menu1'].visibility = 'hide';
    } else {
        document.all['menu1'].style.visibility = 'hidden';
    }
}

function ShowMenu1() {
    if (navAppName === "Netscape") {
        currentLayer = eval('document.layers[\'menu1\']');
        currentLayer.visibility = 'show';
    } else {
        currentLayer = eval('document.all[\'menu1\']');
        currentLayer.style.visibility = 'visible';
    }
}

function HideMenu2() {
    if (navAppName === "Netscape") {
        document.layers['menu2'].visibility = 'hide';
    } else {
        document.all['menu2'].style.visibility = 'hidden';
    }
}

function ShowMenu2() {
    if (navAppName === "Netscape") {
        currentLayer = eval('document.layers[\'menu2\']');
        currentLayer.visibility = 'show';
    } else {
        currentLayer = eval('document.all[\'menu2\']');
        currentLayer.style.visibility = 'visible';
    }
}
