import React from 'react'
import bg from '../images/login-bg.jpg'
import logo from '../images/Logo-GA.png'
import LoginForm from './LoginForm';
import '../css/cssLogin.css'

function Login() {
    return (
        <div>
            <section class="h-100 gradient-form" style={{ backgroundColor: "#eee" }} >
                <div class="container py-5 h-100">
                    <div class="row d-flex justify-content-center align-items-center h-100">
                        <div class="col-xl-10">
                            <div class="card rounded-3 text-black">
                                <div class="row g-0">
                                    <div class="col-lg-6">
                                        <div class="card-body p-md-5 mx-md-4">
                                            <div class="text-center">
                                                <img src={logo} style={{ width: "65px", height: "65px" }} />
                                                <h4 class="mt-1 mb-5 pb-1">Bienvenido a GestiApp</h4>
                                            </div>
                                            <LoginForm />
                                        </div>
                                    </div>
                                    <div class="col-lg-6 d-flex align-items-center gradient-custom-2">
                                        <div class="text-white px-3 py-4 p-md-5 mx-md-4">
                                            <h1 class="mb-4">BIENVENIDO A #GestiApp</h1>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div >
    );
}
export default Login;

