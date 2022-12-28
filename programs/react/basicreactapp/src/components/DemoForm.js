import React,{useState} from 'react'

const DemoForm=()=>{
    const [name,setName]=useState('raghu')

    const handleChange=(e)=>{
        setName(e.target.value)
    }
    return (
        <form>
            <input value={name} onChange={handleChange}/>
            <h1>Your name is - {name}</h1>

        </form>
    )
}
export default DemoForm