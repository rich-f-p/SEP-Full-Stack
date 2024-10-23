// 1. Write the code to sum all salaries and store in the variable sum. Should be 390 in the example above.
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
}

function sumAll(){
    let sum = 0;
    for(let key in salaries){
        sum+=salaries[key];
    }
    console.log(sum)
    return sum;
}

// 2. Create a function multiplyNumeric(obj) that multiplies all numeric properties of obj by 2
let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};
function multiplyNumeric(obj){
    for(let key in obj){
        if(typeof(obj[key])=="number"){
            menu[key]=2*obj[key];
        }
    }
}
//3.Write a function checkEmailId(str) that returns true if str contains '@' and ‘.’, otherwise false. Make sure
//'@' must come before '.' and there must be some characters between '@' and '.'
function checkEmailId(str){
    let chk1 = str.indexOf('@');
    let chk2 = str.indexOf('.');
    if(chk1>-1 && chk2>-1 && chk2>chk1+1){
        return true
    }
    return false;
}

//4.Create a function truncate(str, maxlength) that checks the length of the str and, if it exceeds maxlength
//– replaces the end of str with the ellipsis character "...", to make its length equal to maxlength.
function truncate(str,maxlength){
    if(str.length>maxlength){
        let str2 = ""
        for(var i=0;i<=maxlength-2;i++){
            str2+=str.charAt(i);
            console.log(str.charAt(0))
        }
        return(str2+"...")
    }
    return str;
}

//5.Let’s try 5 array operations.
let arr = ["James","Brennie"];
console.log(arr)
arr.push("Robert")
console.log(arr);
arr.splice(arr.length/2,1,"Calvin")
console.log(arr);
arr.shift();
console.log(arr);
arr.unshift("Rose","Regal");
console.log(arr);


function run(){
    //console.log(truncate("What I'd like to tell on this topic is:", 20))
    //console.log(checkEmailId("@test."))
    //multiplyNumeric(menu);
}
run();
