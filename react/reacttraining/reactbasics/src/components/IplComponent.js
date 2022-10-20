import React from 'react'

function IplComponent() {
    const ipldash=
    [
        {
            id:1,
            name:'GT',
            matches:'6',
            win:'5',
            lost:'1',
            points:'10',

        },
        {
            id:2,
            name:'PT',
            matches:'6',
            win:'5',
            lost:'1',
            points:'10',
        },
        {
            id:3,
            name:'PG',
            matches:'6',
            win:'5',
            lost:'1',
            points:'10',
        }

]
  return (
    <div>
        <h1>IPL Dashboar</h1>
        <table>
         <tr>
             <th>Team ID</th>
             <th>Name</th>
             <th>Matches</th>
             <th>Lost</th>
             <th>Points</th>
         </tr>
         {ipldash.map((ipldash)=>
         <tr key={ipldash.id}>
             <td>{ipldash.id}</td>
             <td>{ipldash.name}</td>
             <td>{ipldash.matches}</td>
             <td>{ipldash.win}</td>
             <td>{ipldash.points}</td>
         </tr>
         )}
        </table>
        <br></br>
    </div>
    
  )
}

export default IplComponent