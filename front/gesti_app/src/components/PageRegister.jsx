import React from 'react'
import { Link } from 'react-router-dom';

function PageRegister() {
    return (
        <body className="text-center bg-light p-4">
            <main className="form-signin w-100 m-auto" style={{ padding: "15px", maxWidth: "330px" }}>
                <form>

                    <h1 className="h3 mb-3 fw-normal">Ingresa</h1>
                    <div className="pb-3">
                        <div className="form-floating">
                            <input type="email" className="form-control" id="floatingInput" placeholder="name@example.com" />
                            <label for="floatingInput">Email address</label>
                        </div>
                        <div className="form-floating">
                            <input type="password" className="form-control" id="floatingPassword" placeholder="Password" />
                            <label for="floatingPassword">Password</label>
                        </div>
                    </div>
                    <button className="w-100 btn btn-lg btn-primary" type="submit">Entrar</button>
                    <p className="mt-5 mb-3 text-muted">©2022</p>
                </form>
            </main>
        </body >
    );
}
export default PageRegister;

