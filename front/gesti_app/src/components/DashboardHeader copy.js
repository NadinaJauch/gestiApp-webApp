import React from 'react'
import { Link } from 'react-router-dom';
import logo from '../images/Logo-GA.png'


function DashboardHeader() {
    return (
        <header class="w-100 bottomBorder">
            <div className="px-3 py-2 border-bottom">
                <div className="container d-flex flex-wrap justify-content-end align-items-center">

                    <div>
                        <Link to="/login"><button type="button" className="btn btn-light text-dark me-2 m-3" >Cerrar sesión</button></Link>
                    </div>
                </div>
            </div>
        </header >
    );
}
export default DashboardHeader;
