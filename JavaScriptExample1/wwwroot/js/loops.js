for (let i = 1; i <= 10; i++) {
    console.log(i);
}

for (let i = 20; i > 0; i--) {
    console.log(i);
}

let count = 0;

while (count <= 100) {
    console.log(count);
    count++;
}

count = 0;

do {
    console.log(count);
    count++;
} while (count <= 100);


let myHouse = {
    "floors": 2,
    "siding": "aluminum",
    "basement": true
}

for (let key in myHouse) {
    console.log(key);
}

//for (let key of myHouse) {
//    console.log(key);
//}

console.log(((1 / 0) + ' ' + 'b' + 'a' + + 'How Many Bananas?' + 'as').toLowerCase().replace('y', 'e'));