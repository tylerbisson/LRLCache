import React, { useEffect, useState } from 'react';

export default function Nav() {
    const [currentUser, setCurrentUser] = useState([]);

    useEffect(() => {
        $.ajax({
            method: 'get',
            url: `get_current_user`
        }).then(data => {
            setCurrentUser(data)
        })
    }, []);

    return (
        <div>
            <h2>{currentUser["username"]}</h2>
        </div>
    );
}

