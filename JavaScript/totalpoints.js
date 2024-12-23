function points(games) {
    let p = 0;
    games.forEach((value) => { 
        if(Number(value[0]) > Number(value[value.length - 1])) {
            p+=3;
        }
        else if(Number(value[0]) == Number(value[value.length - 1])) {
            p++;
        }
    });
    return p;
}

const amount = ["1:0","2:0","3:0","4:0","2:1","3:1","4:1","3:2","4:2","4:3"];
const amount1 = ["1:1","2:2","3:3","4:4","2:2","3:3","4:4","3:3","4:4","4:4"];
const amount2 = ["1:0","2:0","3:0","4:0","2:1","1:3","1:4","2:3","2:4","3:4"];
let finPoint = points(amount);
let finPoint1 = points(amount1);
let finPoint2 = points(amount2);
console.log(finPoint);
console.log(finPoint1);
console.log(finPoint2);