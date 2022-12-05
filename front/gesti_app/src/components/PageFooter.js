import React from 'react'

function PageFooter() {
    return (
        <div className="container">
            <footer className="py-5">
                <div className="row">
                    <div className="col-6 col-md-2 mb-3">
                        <h5>CONÓCENOS</h5>
                        <ul className="nav flex-column">
                            <li className="nav-item mb-2"><a href="#" className="nav-link p-0 text-muted">De qué se trata GestiApp?</a></li>
                            <li className="nav-item mb-2"><a href="#" className="nav-link p-0 text-muted">Quiénes somos?</a></li>

                        </ul>
                    </div>

                    <div className="col-6 col-md-2 mb-3">
                        <h5>SOPORTE Y AYUDA</h5>
                        <ul className="nav flex-column">
                            <li className="nav-item mb-2"><a href="" className="nav-link p-0 text-muted">Preguntas frecuentes</a></li>
                            <li className="nav-item mb-2"><a href="#" className="nav-link p-0 text-muted">gestiapp@mail.com</a></li>
                        </ul>
                    </div>
                </div>

                <div className="d-flex flex-column flex-sm-row justify-content-between py-4 my-4 border-top">
                    <p>© Gesti-App2022 Company, Inc. All rights reserved.</p>
                    <ul className="list-unstyled d-flex">
                        <li className="ms-3"><a className="link-dark" href="#"><h5><i class="bi bi-facebook"></i></h5></a></li>
                        <li className="ms-3"><a className="link-dark" href="#"><h5><i class="bi bi-instagram"></i></h5></a></li>
                        <li className="ms-3"><a className="link-dark" href="#"><h5><i class="bi bi-twitter"></i></h5></a></li>
                    </ul>
                </div>
            </footer>
        </div>
    );
}
export default PageFooter;
