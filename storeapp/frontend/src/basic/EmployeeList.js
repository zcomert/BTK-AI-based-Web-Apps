import Header from "../components/header/Header";
import Employee from "./Employee";

const EmployeeList = () => {

    const employees = [
        { id: 1, firstName: "Ahmet", lastName: "Can", salary: 40000 },
        { id: 2, firstName: "Mehmet", lastName: "Kan", salary: 30000 },
        { id: 3, firstName: "Fatma", lastName: "Dağ", salary: 50000 },
        { id: 4, firstName: "Aylin", lastName: "Güneş", salary: 25000 },
        { id: 5, firstName: "Deniz", lastName: "Ay", salary: 38000 },
    ];
    return (
        <div>
            <Header data={{ title: "Çalışanlar" }}></Header>
            {
                employees.map((emp) => (
                    <div key={emp?.id} >
                        <Employee employee={emp} />
                    </div>))
            }
        </div>
    )
}
export default EmployeeList;