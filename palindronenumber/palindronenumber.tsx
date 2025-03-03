
const x = 100;

function isPalindrome(x: number): boolean {
    const arrf: number[] = [];
    const arrb: number[] = [];
    let truth : boolean = true;
    let y: number = x;
    //If x is negative return false
    if (x < 0){
        return false;
    } 
    // cant use module for comparison because 10%10 = 0, 100%10=0, 4000%10=0 etc....
    for (let i : number = 0; 0 < x / 10; i++){
        arrb[i] = x % 10;
        arrf.unshift(x % 10);
        x = Math.floor(x / 10);
    }
    //Cant compare in the first for loop as we would be comparing the same number each time.
    //ie Cant compare end of array to beginning of array as we build them. 
    for (let i: number = 0; i < arrf.length; i++){
        console.log("array forwrd=" + arrf[i])
        console.log("array backwards=" + arrb[i])
        console.log("")
        if (arrf[i] != arrb[i] )
            {
                truth = false;
            }

    }

    return truth;
};


console.log(isPalindrome(x));