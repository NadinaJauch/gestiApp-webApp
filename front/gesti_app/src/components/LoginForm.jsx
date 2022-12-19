import React,{useState} from 'react'
import { Link } from 'react-router-dom';
//servicio
import {ApiURL} from '../services/apiRest.js'
//librerias
import {setUserInLocalStorage,  cleanLocalStorage
, getTheLoginResponse} from '../services/localStorageService.js'

class LoginForm extends React.Component {
    state={
        form:{
            "Mail":"",
            "Password":""
        },
        error:false,
        errorMsg:""
    }
    
    controlFormSubmit =e=>{
        e.preventDefault();
    }

    controlChange = async e =>{
        await this.setState({
            form:{
                ...this.state.form,
            [e.target.name] : e.target.value
            }
        });
        console.log(this.state.form)
    }

   logIn = async () =>{
    const response = await getTheLoginResponse(this.state.form);
    const token = await response.json();
    if (response.status === 200) {
        window.localStorage.setItem('secure-gestiApp', token);
        setUserInLocalStorage();
        console.log("se realizó el fetch y se guardó el token en local storage")
       window.location.href = "/home/"
    }
    else if (response.status === 401) {
        cleanLocalStorage()
        this.setState(state => ({
            respuesta: "Credenciales incorrectas"
        }))
    }

    return 
    }


render(){
    return(
<React.Fragment>
        <form onSubmit={this.controlSubmit}>
            <p>Ingresar</p>
            <p style={{color:"red"}}>{this.state.respuesta}</p>
            <div className="form-outline mb-4">
                 {/* mail  */}
                <input type="email" id="Mail" className="form-control" name="Mail" onChange={this.controlChange}/>

                <label className="form-label" for="form2Example11" >mail</label>
            </div>
            <div className="form-outline mb-4">
                {/* password  */}
                <input type="password" id="Password"  name="Password" className="form-control" onChange={this.controlChange}/>
                <label className="form-label" for="form2Example22">contraseña</label>
            </div>

            <div className="text-center pt-1 mb-5 pb-1">

                {/* SUBMIT  */}
                <input className="btn btn-primary btn-block fa-lg gradient-custom-2 mb-3" type="submit" id="idSubmit" value="Entrar" onClick={this.logIn}/>

                <a className="text-muted d-block" href="#!">Olvidaste tu contraseña?</a>
            </div>
            <div className="d-flex align-items-center justify-content-center pb-4">
                <p className="mb-0 me-2">No estás registrado?</p>
                <button type="button" className="btn btn-outline-danger">Registrarse</button>
            </div>
 </form >
       
</React.Fragment>
    );
}
}

export default LoginForm;
