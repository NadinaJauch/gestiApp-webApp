export async function getUser() {
    const api = "http://localhost:5174/getUsuario"
    const request =
    {
        headers: {
            'Content-Type': 'application/json',
            'Authorization': "Bearer " + localStorage.getItem("secure-gestiApp")
        },
        method: "GET",
    }
    var response = await fetch(api, request).then(res => { return res; }).catch(error => { return error });
    return await response
}

export async function setUserInLocalStorage() {
    let user = await getUser()
    window.localStorage.setItem('user-gestiApp', JSON.stringify(user.json()));
}


export async function getTheLoginResponse(data) {
    const api = "http://localhost:5174/security/login"
    const request = {
        headers: { 'Content-Type': 'application/json' },
        method: "POST",
        body: JSON.stringify(data)
    }

    var response = await fetch(api, request).then(res => { return res; }).catch(error => { return error });
    return await response
}

export async function getTheToken(response) {
    return response.token;
}

export async function giveLoginResponse(response) {
    if (response.status === 200) {
        var token = await response.json();
        window.localStorage.setItem('secure-gestiApp', token);
        setUserInLocalStorage();
        return token
    }
    else if (response.status === 401) {
        this.setState(state => ({
            respuesta: "Credenciales incorrectas"
        }))
    }
}


export function cleanLocalStorage() {
    window.localStorage.setItem('secure-gestiApp', "");
    window.localStorage.setItem('user-gestiApp', "");
}

export async function isLoggedIn() {
    let respuesta = await getUser()
    if (await respuesta.status === 200) {
        return true
    }
    return false
}

export function unauthorized() {
    window.location.href = "/login/"
}