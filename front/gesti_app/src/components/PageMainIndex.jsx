import React from 'react'
import coins from '../images/Coins.png'

function PageMainIndex() {
    return (
        <main>
            <div className="position-relative overflow-hidden p-3 p-md-5 text-center bg-light">
                <div className="col-md-5 p-lg-5 mx-auto my-5">
                    <img src={coins} className="img-fluid" style={{ width: "100px", height: "100px" }} />
                    <h1 className="display-4 fw-normal">GestiApp</h1>
                    <p className="lead fw-normal">Tené un control de tus finanzas, obteniendo reportes sobre cuánto gastaste, y
                        en
                        que más gastaste </p>
                    <a className="btn btn-outline-secondary" href="#">Coming soon</a>
                </div>
                <div className="product-device shadow-sm d-none d-md-block"></div>
                <div className="product-device product-device-2 shadow-sm d-none d-md-block"></div>
            </div>

        </main>
    );
}
export default PageMainIndex;
