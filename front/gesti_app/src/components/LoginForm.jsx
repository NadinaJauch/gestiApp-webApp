import React,{useState} from 'react'
import { Link } from 'react-router-dom';
//servicio
import {ApiURL} from '../services/apiRest.js'
//librerias

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

    //submit
    controlSubmit = async () =>{
        const api = "http://localhost:5174/security/login"
        const request = {
        headers:{'Content-Type': 'application/json'},
        method: "POST",
        body: JSON.stringify(this.state.form)}
        
        var response = await fetch(api,request).then( res  => {
        return res;
        }).catch(error =>{
            return error
        });

        if (response.status === 200)
        {
            var token = await response.json()
            const redirectHome = () => {
            window.location.href = '/home'
        }
        redirectHome()
        } 
        else if (response.status === 401)
        {
            this.setState(state =>({
            respuesta: "Credenciales incorrectas" }))
        }
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
                <input className="btn btn-primary btn-block fa-lg gradient-custom-2 mb-3" type="submit" id="idSubmit" value="Entrar" onClick={this.controlSubmit}/>


                <a className="text-muted d-block" href="#!">Olvidaste tu contraseña?</a>
            </div>
            <div className="d-flex align-items-center justify-content-center pb-4">
                <p className="mb-0 me-2">No estás registrado?</p>
                <Link to="/login"><button type="button" className="btn btn-outline-danger">Registrarse</button></Link>
            </div>
 </form >
       
</React.Fragment>
    );
}
}

export default LoginForm;
