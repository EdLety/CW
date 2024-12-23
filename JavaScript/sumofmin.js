function sumOfMinimums(arr) {
    /* let Minimal = 0;
    arr.forEach((value) => {
        Minimal += Math.min(...value);
    })

    return Minimal; */
    
    return arr.reduce((total, row) => total + Math.min(...row), 0);
}

const arrFull1 = [[7, 9, 8, 6, 2], [6, 3, 5, 4, 3], [5, 8, 7, 4, 5]];
const arrFull2 = [[11, 12, 14, 54], [67, 89, 90, 56], [7, 9, 4, 3], [9, 8, 6, 7]];
let x1 = sumOfMinimums(arrFull1);
let x2 = sumOfMinimums(arrFull2);
console.log(x1);
console.log(x2);