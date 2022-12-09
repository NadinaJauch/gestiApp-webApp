import React from 'react'
import { Link } from 'react-router-dom';
import logo from '../images/Logo-GA.png'
import DashboardHeader from './DashboardHeader copy';
import DashboardReport from './DashboardReport';
import LayoutsSidebar from './LayoutsSidebar';
import PageFooter from './PageFooter';


class LoginForm extends React.Component{

render(){
    return (
        <div className="  d-flex h-screen" style={{ minHeight: "100vh" }}>
            <LayoutsSidebar />
            <div className=" flex-col overflow-hidden w-100">
                <DashboardHeader />
                {/* dashboard main content */}
                <main className="d-flex  bg-light justify-content-center" style={{ minHeight: "100vh" }}>

                    <div class="container m-5 w-100">
                        <div>
                            <div class="justify-content-between d-flex">
                                <div class="card rounded-1 p-4 table-responsive mb-4 card-balance" stlye={{ minHeight: "300px" }}>
                                    <h1>BALANCE: $</h1>
                                    <h1></h1>
                                </div>
                                <button class=" btn btn-outline-success rounded-1 p-4 mb-4 w-30  align-items-center text-center" stlye={{ minHeight: "300px" }}>
                                    <h1>✚</h1>
                                    <p>REGISTRAR MOVIMIENTO</p>
                                </button>
                            </div>
                            <div class="card w-100 rounded-1 p-4 table-responsive" stlye={{ minHeight: "300px" }}>
                                <DashboardReport />
                            </div>
                        </div>
                    </div>
                </main>
            </div>
        </div>
    );
}
}
export default LoginForm;
