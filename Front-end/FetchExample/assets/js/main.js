
const row=document.querySelector(".row")



fetch("https://api.tvmaze.com/shows")
.then(response=>response.json())
.then(shows=>{
    shows.forEach(show=>{
        row.innerHTML+=` <div class="col-3">
                <div class="card" style="width: 18rem;">
                    <img src="${show.image.medium}" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">${show.name}</h5>
                        <p class="card-text">${show.rating.average}</p>
                        <a href="details.html?id=${show.id}" class="btn btn-primary">Details</a>
                    </div>
                </div>
            </div>`
    })
})















// const listTag=document.querySelector("ul")





// fetch("https://jsonplaceholder.typicode.com/users")
// .then(response=>response.json())
// .then(users=>{
    
//     users.forEach(user=>{
//         listTag.innerHTML+=`<li>${user.id} ${user.name}  ${user.address.city}</li>`
//     })
// })

// var id=window.prompt("Please choose Id:")


// fetch(`https://jsonplaceholder.typicode.com/users/${id}`)
// .then(response=>response.json())
// .then(user=>{
//     listTag.innerHTML=`<li>${user.id} ${user.name} ${user.username} ${user.email}  ${user.address.city}</li>`
// })