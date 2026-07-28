

const btns=document.querySelectorAll(".delete-btn")

btns.forEach(btn=>{
    btn.addEventListener("click",(e)=>{
        e.target.closest(".col-4").remove()
    })
})







// const form=document.querySelector("#student-form")
// const listTag=document.querySelector("#list")
// const nameInput=document.querySelector("#name")


// form.addEventListener("submit",(e)=>{
//     e.preventDefault()
//     listTag.innerHTML+=`<li>${nameInput.value}</li>`

//     nameInput.value=""
//     nameInput.focus()
// })






















// const body=document.querySelector("body")

// let opacity=1;

// body.addEventListener("keydown",(e)=>{

//     if(opacity!=0 && e.key=="ArrowDown"){
//        opacity-=0.1
//     }
//     else if(opacity!=1 && e.key=="ArrowUp"){
//         opacity+=0.1
//     }
//     body.style.backgroundColor=`rgba(0, 0, 139, ${opacity})`
//     console.log(e)
// })














// const btn=document.querySelector("#btn1")
// var isActive=false
// btn.onclick=function(){
//     btn.style.backgroundColor="red"
// }



// btn.onclick=()=>btn.style.backgroundColor="red"
// btn.onclick=()=>btn.style.color="white"

// btn.addEventListener("click", (e)=>{

//         e.target.style.backgroundColor="red"

//     if(e.shiftKey==true){
//         e.target.remove()
//     }
    
//     console.log(e)
// })


// btn.addEventListener("click", ()=>btn.style.color="white")


// const div=document.querySelector(".cus-div")

// div.addEventListener("mousemove",function(){
//     console.log("Salam")
// })


// div.addEventListener("contextmenu",function(){
//     console.log("menu achildi")

//     this.style.backgroundColor="bisque"
// })









// div.addEventListener("mouseover",function(){
//     console.log("over")

//     this.style.backgroundColor="bisque"
// })



// div.addEventListener("mouseleave",function(){
//     console.log("out")

//     this.style.backgroundColor="brown"
// })








// div.addEventListener("mouseenter",function(){
//     console.log("entered")

//     this.style.backgroundColor="bisque"
// })

// div.addEventListener("mouseout",function(){
//     console.log("out")

//     this.style.backgroundColor="brown"
// })














// 1) products(object) arrayiniz olur.Her objectin name, price ve stock melumatlari olur.
// Js Dom ile Table yaradirsiz. Bashliqlari Name, Price, Stock.
// products arrayinin elementlerinin her birine uygun siralar yaradib table-a yerleshdirirsiz .
// innerHTML istifade elemek olmaz. Cedveli yalniz js kodu ile duzgun strukturda formalashdirin



// const products=[
//         {
//         name:"Fanta",
//         price:12.50,
//         stock:20
//     },
//         {
//         name:"Coca-Cola",
//         price:10.50,
//         stock:55
//     },
//         {
//         name:"Sprite",
//         price:2.50,
//         stock:4
//     }
// ]


// const body=document.querySelector("body");

// const table=document.createElement("table");
// table.setAttribute("border","1")

// const thead=document.createElement("thead");
// const tbody=document.createElement("tbody");

// body.appendChild(table)
// table.appendChild(thead)
// table.appendChild(tbody)


// const headTr=document.createElement("tr")
// thead.appendChild(headTr)

// const nameTh=document.createElement("th");
// const priceTh=document.createElement("th");
// const stockTh=document.createElement("th");

// nameTh.textContent="Name"
// priceTh.textContent="Price"
// stockTh.textContent="Stock"

// headTr.appendChild(nameTh)
// headTr.appendChild(priceTh)
// headTr.appendChild(stockTh)




// for(let i=0; i<products.length; i++){


//    const proRow=document.createElement("tr")
//    const proName=document.createElement("td")
//    const proPrice=document.createElement("td")
//    const proStock=document.createElement("td")

//    proName.textContent=products[i].name
//    proPrice.textContent=products[i].price
//    proStock.textContent=products[i].stock

//     proRow.appendChild(proName)
//     proRow.appendChild(proPrice)
//     proRow.appendChild(proStock)

//     tbody.appendChild(proRow)


// }
