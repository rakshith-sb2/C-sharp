import React,{useState,useEffect} from 'react'
import axios from 'axios'
const Jsonserverpostapi = () => {
    const baseUrl='http://localhost:3006/contacts'
    const [contacts,setContacts]=useState([])

    const [id,setId]=useState('')
    const [name,setName]=useState('')
    const [email,setEmail]=useState('')
    const [mobile,setMobile]=useState('')
    const contact={
        id:0,
        name:'',
        email:'',
        mobile:0
    }
       
    const rowdata =contacts.map((contact)=>
        <tr>
            <td>{contact.id}</td>
            <th>{contact.name}</th>
            <th>{contact.email}</th>
            <th>{contact.mobile}</th>
        </tr>
    );

    useEffect(()=>{
        console.log("axios get called")
        axios.get(baseUrl)
        .then(response=>setContacts(response.data))
      //    .then(response=>console.log(response))
    },[]);

    

    
    const idChanged=(e)=>{          
        setId(e.target.value)      
    }

    const nameChanged=(e)=>{
        setName(e.target.value)

    }

    const emailChanged=(e)=>{
        setEmail(e.target.value)        
    }

    const mobileChanged=(e)=>{
        setMobile(e.target.value)        
    }

    const saveData=(e)=>{
        e.preventDefault();
        console.log("id ",id,"name ",name,"email ",email,"mobile",mobile)  
      
        const user = {
            id:id,
            name:name,
            email:email,
            mobile:mobile

        }
        
    axios
      .post(baseUrl, {
        id:id,
        name:name,
        email:email,
        mobile:mobile
    })
      .then((response) => {
          console.log("response data ",response.data)
        setContacts([...contacts,response.data])
        console.log('contacts updated ',contacts);
      });

      setId(0)
      setName('')
      setEmail('')
      setMobile(0)
    }

    

    return (
       <div> 
        <div>
            <form onSubmit={saveData}>
            <label>ID</label><br></br>
            <input type="text" value={id} onChange={idChanged}/><br></br>
            <label>Name</label><br></br>
            <input type="text" value = {name} onChange={nameChanged}/><br></br>            
            <label>Email</label><br></br>
            <input type="text" value={email} onChange={emailChanged}/><br></br>
            <label>Mobile</label><br></br>
            <input type="text" value={mobile} onChange={mobileChanged}/><br></br>
            <button type = "submit">Save</button>
            </form>
        </div>

<div>
<h1>Contact List</h1>
<table>
<thead>
<tr>
<td>Id</td>
<td>Name</td>
<td>Email</td>
<td>Mobile</td>
</tr>
</thead>
<tbody>                    
{rowdata}           
</tbody>
</table>   
</div>
</div>
    )
}

export default Jsonserverpostapi
