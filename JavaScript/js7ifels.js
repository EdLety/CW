function saleHotdogs(n){
    return n < 5 ? 100 * n : n >= 5 && n < 10 ? 95 * n : n * 90; 
}

const n = 5;
let x;
x = saleHotdogs(n);
console.log(x);