import React, { useState } from 'react'

function Employee({ employee }) {

    const [newSalary, setNewSalary] = useState(employee?.salary)
    return (
        <div>
            <h1>
                {employee?.firstName}
                {employee?.lastName}
            </h1>
            <p>
                {newSalary}
            </p>
            <button onClick={() => setNewSalary(newSalary + 1000)} >+</button>
            <hr />
        </div>
    )
}

export default Employee;
