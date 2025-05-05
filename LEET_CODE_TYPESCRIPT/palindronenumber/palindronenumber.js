var x = 100;
function isPalindrome(x) {
    var arrf = [];
    var arrb = [];
    var truth = true;
    var y = x;
    if (x < 0) {
        return false;
    }
    for (var i = 0; 0 < x / 10; i++) {
        arrb[i] = x % 10;
        arrf.unshift(x % 10);
        x = Math.floor(x / 10);
    }
    for (var i = 0; i < arrf.length; i++) {
        console.log("array forwrd=" + arrf[i]);
        console.log("array backwards=" + arrb[i]);
        console.log("");
        if (arrf[i] != arrb[i]) {
            truth = false;
        }
    }
    // this is not needed as if x < 0, just return false
    // for (let i: number = 0; i < arrf.length; i++)
    // {
    //     if (z < 0)
    //     {
    //         arrf[arrf.length] = arrf[arrf.length] * -1;
    //         arrb[0] = arrb[0] * -1;
    //     }
    //     if (arrf[i] != arrb[i])
    //         {
    //             truth = false;
    //         }
    // }
    return truth;
}
;
console.log(isPalindrome(x));
