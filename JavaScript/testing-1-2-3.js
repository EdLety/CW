function testy(array){
    let mass = [];
    for(let i = 0; i < array.length; i++){
        let y = `${i + 1}: ` + array[i];
        mass[i] = y;
    }
    return mass;
}

let arr = ["a", "b", "c"];
console.log(testy(arr));

// return array.map((item, index) => `${index + 1}: ${item}`);