import React from 'react'

const Employee=(props)=>{

    return(
        <div>
            <h1>Employee</h1>
            <h2>Code : {props.empData.code}</h2>
            <h2>Name : {props.empData.name}</h2>
            <h2>Department : {props.empData.dept}</h2>
            <h2>Designation : {props.empData.desg}</h2>
            <h2>Salary : {props.empData.sal}</h2>
            
        </div>
    )
}

export default Employee