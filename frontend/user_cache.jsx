import React, { useEffect, useState } from 'react';

export default function UserCache() {
    const [records, setRecords] = useState([]);

    useEffect(() => {
        $.ajax({
            method: 'get',
            url: `users/5`
        }).then(data => {
            setRecords(data)
        })
    }, []);

    return (
        <div>
            {records.map(record => (
                <div key={record["id"]}>
                    {record["title"]}
                </div>
            ))}
        </div>
    );
}

