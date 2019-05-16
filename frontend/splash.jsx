import React, { useEffect, useState } from 'react';

export default function Splash() {
    const [users, setUsers] = useState([]);

    useEffect(() => {
            $.ajax({
                method: 'get',
                url: `users/index`
            }).then(data => {
                setUsers(data)
            })
    }, []);

    return (
        <div>
            {users.map(user => (
                <div key={user["id"]}>
                    {user["username"]}
                </div>
            ))}
        </div>
    );
}

