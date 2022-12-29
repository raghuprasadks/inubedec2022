import React from 'react'

const Fifa=(props)=>{

    
    
    return(
        <div>
        <table>
            <tr>
            <th>Code</th>
            <th>Name</th>
            <th>Year</th>
            <th>Position</th>
                        
            </tr>
            {props.fifaData.map((items)=>
         <tr key={items.code}>
             <td>{items.name}</td>
             <td>{items.year}</td>
             <td>{items.position}</td>
             
         </tr>
         )}
        
        </table>
        </div>
    )
}

export default Fifa