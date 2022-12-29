import React,{useState} from 'react'


const Employees=({listEmployees,saveEmployee})=>{

    const [code,setCode]=useState(-1)
    const [name,setName]=useState('')
    const [desg,setDesg]=useState('')
    const [sal,setSal]=useState(-1)
    const addEmployee=(e)=>{
        e.preventDefault()
      saveEmployee({code,name,desg,sal})

      setCode(-1)
      setName('')
      setDesg('')
      setSal(-1)
    }
    return (
        <>        
           <div>
           <div>
           <h1>Employee CRUD</h1>
           <h2>Total Number of Employees : {listEmployees.length}</h2>
           <table>
            <tr>
                <th>Code</th>
                <th>Name</th>
                <th>Designation</th>
                <th>Salary</th>                
            </tr>
            {listEmployees.map((emp)=>{
                return <tr key={emp.code}>
                    <td>{emp.code}</td>
                    <td>{emp.name}</td>
                    <td>{emp.desg}</td>
                    <td>{emp.sal}</td>
                </tr>
            })}
           </table>
           </div>
           <div>
            <form onSubmit={addEmployee}>
                <input value={code} placeholder='Enter employee code' onChange={(e)=>setCode(e.target.value)}/>
                <input value={name} placeholder='Enter employee name' onChange={(e)=>setName(e.target.value)}/>
                <input value={desg} placeholder='Enter employee designation' onChange={(e)=>setDesg(e.target.value)}/>
                <input value={sal} placeholder='Enter employee Salary' onChange={(e)=>setSal(e.target.value)}/>
                <input type='submit' value='Add Employee'></input>
                
            
            </form>
           </div>
           </div>  
           </>      
    )
}

export default Employees