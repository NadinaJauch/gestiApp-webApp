
import React from 'react'
import { Link } from 'react-router-dom';
import logo from '../images/Logo-GA.png'
import DashboardHeader from './DashboardHeader copy';
import '../css/cssDashboard.css'

function LayoutsSidebar() {
    return (
        <div>
            <div class="h-100 bg-dark" style={{ width: "300px" }}>

                <div class="d-flex align-items-center justify-content-center pt-5">
                    <div class="d-flex align-items-center">
                        <img style={{ width: "40px" }} src={logo} />
                        <h3 class="ms-3"><strong class="text-light">Dashboard</strong></h3>
                    </div>
                </div>

                <nav class="mt-4">
                    <a class="d-flex align-items-center text-decoration-none activeElement mb-2" href="/">
                        <span class="ms-5 p-3">Dashboard</span>
                    </a>
                    <a class="d-flex align-items-center text-decoration-none activeElement mb-2" href="/">
                        <span class="ms-5 p-3">Saldos</span>
                    </a>
                    <a class="d-flex align-items-center text-decoration-none activeElement mb-2" href="/">
                        <span class="ms-5 p-3">Presupuestos</span>
                    </a>
                    <a class="d-flex align-items-center text-decoration-none inactiveElement mb-2" href="/ui-elements">
                        <span class="ms-5 p-3">Reportes</span>
                    </a>
                </nav>
            </div>
        </div>
    );
}
export default LayoutsSidebar;
