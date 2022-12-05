import React from 'react'
import { Link } from 'react-router-dom';
function LoginForm() {
    return (

        <form>
            <p>Ingresar</p>
            <div class="form-outline mb-4">
                <input type="email" id="form2Example11" class="form-control" />
                <label class="form-label" for="form2Example11">mail</label>
            </div>
            <div class="form-outline mb-4">
                <input type="password" id="form2Example22" class="form-control" />
                <label class="form-label" for="form2Example22">contraseña</label>
            </div>

            <div class="text-center pt-1 mb-5 pb-1">
                <Link to="/home"><button class="btn btn-primary btn-block fa-lg gradient-custom-2 mb-3" type="button">Entrar</button></Link>
                <a class="text-muted d-block" href="#!">Olvidaste tu contraseña?</a>
            </div>

            <div class="d-flex align-items-center justify-content-center pb-4">
                <p class="mb-0 me-2">No estás registrado?</p>
                <Link to="/login"><button type="button" class="btn btn-outline-danger">Registrarse</button></Link>
            </div>
        </form >

    );
}
export default LoginForm;
