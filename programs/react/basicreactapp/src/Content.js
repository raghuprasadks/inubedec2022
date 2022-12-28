import React from 'react'

const Content=()=>{

    const course = "React";
    const wishlist = ["Angular","ML","Block Chain ","Cyber Security"];
    const emp ={code:1,name:'ramya',dept:'IT',sal:40000};
    return(
        <div>
        <h2> Course - {course} </h2>
        <h3> My Wish List - {wishlist}</h3>
        <h3>Employee Code : {emp.code} - Name - {emp.name}</h3>
        </div>
    );
    }
    export default Content;
