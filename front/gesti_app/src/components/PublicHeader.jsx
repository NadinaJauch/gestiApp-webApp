import React from 'react'
import { Link } from 'react-router-dom';
import logo from '../images/Logo-GA.png'
import '../css/cssLogin.css'

function Header() {
    return (
        <header>
            <div className="px-3 py-2 border-bottom">
                <div className="container d-flex flex-wrap justify-content-between align-items-center">
                    <img src={logo} className="img-fluid" style={{ width: "65px", height: "65px" }} />
                    <div>
                        <Link to="/login"><button type="button" className="btn btn-light text-light me-2 gradient-custom-2" >Loguearse</button></Link>
                        <Link to="/login"><button type="button" className="btn btn-light text-light" style={{ backgroundColor: "#b44593" }}>Registrarse</button></Link>
                    </div>
                </div>
            </div>
        </header >
    );
}
export default Header;
