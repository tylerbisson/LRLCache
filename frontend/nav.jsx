import React, { useEffect, useState } from 'react';

export default function Nav() {
    const [currentUser, setCurrentUser] = useState([]);

    useEffect(() => {
        $.ajax({
            method: 'post',
            url: `/users`,
            data: {
            email: "tbisson11@gmail.com",
            password: "password",
            password_confirmation: "password"
            }
        }).then(data => {
            // setCurrentUser(data)
            console.log(data)
        })
    }, []);

    useEffect(() => {
        $.ajax({
            method: 'get',
            url: `get_current_user`
        }).then(data => {
            // setCurrentUser(data)
            console.log("yooo")
            console.log(data)
        })
    }, []);

    return (
        <div>
            {/* <h2>{currentUser ? null : currentUser["username"]}</h2> */}
            <h2>"what"</h2>
        </div>
    );
}

