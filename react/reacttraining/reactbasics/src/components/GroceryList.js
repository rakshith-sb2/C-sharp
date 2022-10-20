import React from 'react'
export default function GroceryList() {

//export default function GroceryList(props) {
   // const coronaData=props.coronaData
    const items=
    [
        {
            id:1,
            name:'Rice'
        },
        {
            id:2,
            name:'Dal'
        },
        {
            id:3,
            name:'Oil'
        }

]
  return (
    <div>
        <h1>Grocery List</h1>
        <ul>
            {items.map((item)=><li key={item.id}>{item.name}</li>)}
        </ul>
    </div>
  )
}
