

// js DOM  Document Object Model


const students=[
    {
        name:"Tunar",
        surname:"Bextiyarov",
        age:18

    },

     {
        name:"Nigar",
        surname:"Aligayeva",
        age:24

    },

     {
        name:"Mahammedeli",
        surname:"Babayev",
        age:20

    }
]


const bands=[
    {
        name:"Nirvana",
        desc:"hambmsdb nkasbkdbsk ksbdkbakdsjb bkasbdhkj",
        image:"https://www.emp-online.com/dw/image/v2/BBQV_PRD/on/demandware.static/-/Sites-master-emp/default/dwa42e1dcd/images/3/8/1/9/381967a.jpg?sw=1000&sh=800&sm=fit&sfrm=png"
    },

      {
        name:"Metallica",
        desc:"hambmsdb nkasbkdbsk ksbdkbakdsjb ksbjkfjdsbkfbdshfbdskfbkjdsfn",
        image:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT5y7QjjRItr_Jv2ZC6QRxxUFB--xRlzdiAGWQJLsdAgDlhxPFzVU80fh8&s=10"
    },

      {
        name:"AC/DC",
        desc:"agsaqqallar",
        image:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiTylx4vy8AJ32BET6pbK3ejla1F0TDMxy5mKS_iSKkQ&s"
    }
]


const row=document.querySelector(".row")



bands.forEach(band=>{

    row.innerHTML+=` <div class="col">
                <div class="card" style="width: 18rem;">
                    <img src="${band.image}" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">${band.name}</h5>
                        <p class="card-text">${band.desc}</p>
                        <a href="#" class="btn btn-primary">Go somewhere</a>
                    </div>
                </div>
            </div>`
})



                


// const ulTag=document.createElement("ul")
// body.appendChild(ulTag)

// for(let i=0; i<students.length; i++){

//     const item=document.createElement("li")
//     item.textContent=`${students[i].name} ${students[i].surname} ${students[i].age}`

//     ulTag.appendChild(item)
// }






















// const divisions=document.getElementsByClassName("col")







// const btn= document.querySelector("#dark")
// const body= document.querySelector("body")

// btn.onclick=function(){
//      body.classList.toggle("dark-mode")

//      btn.classList.toggle("dark-btn")
// }











// const inputName=document.querySelector("#name")


// inputName.setAttribute("placeholder","Name")











// const divs=document.querySelectorAll(".col")

// divs.forEach(div=>{
//     // div.innerText="Salam"

//     div.classList.toggle("text-red")


//    const parag= document.createElement("p")
//    parag.textContent="salam"

//    div.appendChild(parag)

// //    div.classList.remove("col")

// })










// console.log(divisions)
// console.log(divs)





// for(let i=0; i<divisions.length;i++){

//     divisions[i].style.backgroundColor="red"
//     divisions[i].style.width="50px"
//     divisions[i].style.height="50px"
//     divisions[i].style.border="1px black solid"

// }


// const title=document.getElementById("title")

// title.style.color="red"

// console.log(document.body)