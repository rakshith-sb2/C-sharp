import React,{useState} from 'react'
export const DemoForm = () => {
    const [name,setName] = useState('raghu')
    const handleChange=(e)=>{
        console.log(e.target.value)
        setName(e.target.value)
    }
  return (
    <div>
        <form>
            <input value={name} onChange={handleChange}/>
            <h1>Your name is {name}</h1>
        </form>
    </div>
  )
}
