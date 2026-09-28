let autoIncrementUserId = 1000;
let autoIncrementMedicineId = 100;
let autoIncrementOrderId = 2000;

class User{
    UserId : string;
    Name : string;
    Email : string;
    Password : string;
    UserPhoneNumber : string;
    Amount : number = 0;

    constructor(name:string,email:string , password:string , userPhoneNumber : string){
        this.UserId = 'UID'+ ++autoIncrementUserId;
        this.Name = name;
        this.Email = email;
        this.Password = password
        this.UserPhoneNumber = userPhoneNumber;
    }
}

class Medicine{
    MedicineId : string;
    MedicineName : string;
    MedicineCount : number;
    MedicinePrice : number;
    ExpiryDate : Date;

    constructor(medicineName : string , medicineCount : number , medicinePrice : number , expiryDate : Date ){
        this.MedicineId = 'MD'+ ++autoIncrementMedicineId;
        this.MedicineName = medicineName;
        this.MedicineCount = medicineCount;
        this.MedicinePrice = medicinePrice;
        this.ExpiryDate = expiryDate;

    }
}

enum orderStatus{ 
    purchased = 'purchased',
    cancelled = 'cancelled'
}

class Order{
    OrderId : string;
    MedicineId : string;
    UserId : string;
    Total : number;

    MedicineName : string;
    MedicineCount:number;
    PurchaseStatus : orderStatus;
    OrderDate : Date;

    constructor(medicineId : string , userId : string , total : number , medicineName : string , medicineCount : number ,date:Date, purchaseStatus : orderStatus){
        this.OrderId = 'OID'+ ++autoIncrementOrderId;
        this.MedicineId = medicineId;
        this.UserId = userId;
        this.Total = total;
        this.MedicineName = medicineName;
        this.MedicineCount = medicineCount;
        this.OrderDate = date;
        this.PurchaseStatus= purchaseStatus;

    }
}


let UserArrayList: Array<User> = new Array<User>();

UserArrayList.push(new User("Ravi", "ravi@gmail.com", "1", "9789011226"));
UserArrayList.push(new User("Baskaran", "baskaran@gmail.com", "Baskaran@1", "9445153060"));

let MedicineList: Array<Medicine> = new Array<Medicine>();

MedicineList.push(new Medicine("Paracetomol",5, 5, new Date(2024, 6, 30)));
MedicineList.push(new Medicine("Colpal", 5, 5, new Date(2024, 5, 30)));
MedicineList.push(new Medicine("Gelucil", 4, 40, new Date(2024, 4, 30)));
MedicineList.push(new Medicine("Metrogel", 5, 50, new Date(2024, 12, 30)));
MedicineList.push(new Medicine("Povidin Iodin", 5, 50, new Date(2024, 10, 30)));

let OrderList: Array<Order> = new Array<Order>();
OrderList.push(new Order("MD101","UID1001" ,15 ,'Paracetomol', 3, new Date(2022, 11, 13), orderStatus.purchased));
OrderList.push(new Order("MD102","UID1001" ,10 ,'Paracetomol', 2, new Date(2022, 11, 13), orderStatus.cancelled));
OrderList.push(new Order("MD104","UID1001" ,100 ,'Paracetomol', 3, new Date(2022, 11, 13), orderStatus.purchased));
OrderList.push(new Order("MD103","UID1002" ,120 ,'Colpal', 3, new Date(2022, 11, 13), orderStatus.cancelled));
OrderList.push(new Order("MD105","UID1002" ,250 ,'Colpal', 5, new Date(2022, 11, 13), orderStatus.purchased));
OrderList.push(new Order("MD102","UID1002" ,15 ,'Colpal', 3, new Date(2022, 11, 13), orderStatus.purchased));


var currentUser: User;

var homepage = document.getElementById("homepage") as HTMLDivElement;
var medicinepage = document.getElementById("medicinepage") as HTMLDivElement;
var purchasepage = document.getElementById("purchasepage") as HTMLDivElement;
var topuppage = document.getElementById("topuppage") as HTMLDivElement;
var orderpage = document.getElementById("orderpage") as HTMLDivElement;

var signInForm = document.getElementById("signIn") as HTMLDivElement;
var signUpForm = document.getElementById("signUp") as HTMLDivElement;
var signInButton = document.getElementById("signInButton") as HTMLDivElement;
var signUpButton = document.getElementById("signUpButton") as HTMLDivElement;

function signIn() : void{
    signInForm.style.display = "block";
    signUpForm.style.display = "none";
    signInButton.style.background = "orange";
    signUpButton.style.background = "none";
}
function signUp() : void{
    signInForm.style.display="none";
    signUpForm.style.display="block";
    signInButton.style.background="none";
    signUpButton.style.backgroundColor="orange";
}


async function signUpSubmit(e){
    e.preventDefault();

    var name = document.getElementById("name") as HTMLInputElement;
    var email = document.getElementById("email") as HTMLInputElement;
    var password = document.getElementById("password") as HTMLInputElement;
    var confirmpassword = document.getElementById("cpassword") as HTMLInputElement;
    var phone = document.getElementById("phone") as HTMLInputElement;

    var useravail : boolean = true;

    UserArrayList.forEach((val)=>{
        if(val.Email.toLowerCase()==email.value.toLowerCase()){
            alert("You already have an account")
            useravail = false;
        }
    })

    if(useravail){
        var user:User = new User(name.value,email.value,password.value,phone.value);
        UserArrayList.push(user);
        alert("Your User ID "+user.UserId)
        // useravail=false;
    }
    else{
        var i = document.getElementById("signUp") as HTMLDivElement;
        i.style.border="2px solid red";
    }

}

async function signInSubmit(e){

    e.preventDefault();

    var isavail: boolean = true;
    var email2 = document.getElementById("email2") as HTMLInputElement;
    var password2 = document.getElementById("password2") as HTMLInputElement;

    UserArrayList.forEach((user)=>{
        
        if(user.Email.toLowerCase()==email2.value.toLowerCase() && user.Password==password2.value){
            var a = document.getElementById("box") as HTMLDivElement;
            a.style.display="none";
            var b = document.getElementById("menu") as HTMLDivElement;
            b.style.display="block";
            isavail=false;
            currentUser = user;
            home();
            email2.value="";
            password2.value="";
        }
    })
    if(isavail){
        alert("Invlaid User Or Password")
    }
}
 
async function displayNone(){
    homepage.style.display="none";
    medicinepage.style.display="none";
    purchasepage.style.display="none";
    topuppage.style.display="none";
    orderpage.style.display="none";
    (document.getElementById("addEditMedicineForm") as HTMLDivElement).style.display="none";
}

async function home(){
    displayNone();
    homepage.style.display="block";
    var welcome = document.getElementById("Welcome") as HTMLHeadElement;
    welcome.innerHTML = "Welcome   " + currentUser.Name;
}

async function showmedicine(){
    displayNone();
    medicinepage.style.display="block";
    var table = document.getElementById("medicineTable") as HTMLTableElement;
    var len = table.getElementsByTagName("tr").length;

    //removing the each and every row in the table
    if(table.hasChildNodes()) {
        for(var i=len-1;i>=1;i--){
            table.removeChild(table.children[i]);
        }
    }

    //adding the rows
    MedicineList.forEach((medicine)=>{
        var row = document.createElement("tr") as HTMLTableRowElement;
        row.innerHTML = `<td>${medicine.MedicineId} </td>  <td> ${medicine.MedicineName} </td> <td> ${medicine.MedicinePrice} </td> <td>${medicine.MedicineCount} </td> 
        <td>${medicine.ExpiryDate.toLocaleDateString()} </td>
        <td>
            <button onclick="editMedicine('${medicine.MedicineId}')">Edit</button>
            <button onclick="deleteMedicine('${medicine.MedicineId}')">Delete</button>
        </td>`;
        table.appendChild(row);
    })
}

let editMedicineID : string;
async function deleteMedicine(medicineId : string){
    var index = MedicineList.findIndex(val => val.MedicineId==medicineId);
    MedicineList.splice(index,1);
    showmedicine();

}

async function addMedicine(){
    (document.getElementById("addEditMedicineForm") as HTMLDivElement).style.display="block";
    editMedicineID="";
}

async function editMedicine(medicineId : string){
    (document.getElementById("addEditMedicineForm") as HTMLDivElement).style.display="block";
    var medicine = MedicineList.find(val => val.MedicineId== medicineId);
    if(medicine){
        var name = document.getElementById("medicineName") as HTMLInputElement;
        var count = document.getElementById("medicineCount") as HTMLInputElement;
        var price = document.getElementById("medicinePrice") as HTMLInputElement;
        var expiryDate = document.getElementById("expiryDate") as HTMLInputElement;
        name.value = medicine.MedicineName;
        count.value = medicine.MedicineCount.toString();
        price.value = medicine.MedicinePrice.toString();
        expiryDate.value = medicine.ExpiryDate.toISOString().split('T')[0];
        editMedicineID = medicine.MedicineId;

    }

}




async function addEditMedicine(){
    var name = document.getElementById("medicineName") as HTMLInputElement;
    var count = document.getElementById("medicineCount") as HTMLInputElement;
    var price = document.getElementById("medicinePrice") as HTMLInputElement;
    var expiryDate = document.getElementById("expiryDate") as HTMLInputElement;

    var dateSplit: string[] = expiryDate.value.split("-");

    var medicineData = MedicineList.find(val => val.MedicineId == editMedicineID);

    if(medicineData)
        {
            medicineData.MedicineName = name.value;
            medicineData.MedicineCount = Number(count.value);
            medicineData.MedicinePrice = Number(price.value);
            medicineData.ExpiryDate = new Date(Number(dateSplit[0]), (Number(dateSplit[1]) - 1), (Number(dateSplit[2])));
            alert("Medicine details updated successfully");
            editMedicineID="";
        }
        else 
        {
            if (name.value.trim() != "") {
                MedicineList.push(new Medicine(name.value, Number(count.value), Number(price.value), new Date(Number(dateSplit[0]), (Number(dateSplit[1]) - 1), Number(dateSplit[2]))));
                alert("Medicine details added successfully");
                editMedicineID="";
            }
        }
        name.value = "";
        count.value = "";
        price.value = "";
        expiryDate.value = "";
        showmedicine();
}

async function purchase(){
    displayNone();
    purchasepage.style.display="block";
    var purchaseTable = document.getElementById("purchaseTable") as HTMLTableElement;
    var len = purchaseTable.getElementsByTagName("tr").length;

    if(purchaseTable.hasChildNodes()){
        for(var i=len-1;i>=1;i--){
            purchaseTable.removeChild(purchaseTable.children[i]);
        }
    }

    MedicineList.forEach((medicine) =>{
        var row = document.createElement("tr") as HTMLTableRowElement;
        row.innerHTML=`<td>${medicine.MedicineId} <td> ${medicine.MedicineName} </td> <td> ${medicine.MedicinePrice} </td> <td>${medicine.MedicineCount} </td> 
        <td>${medicine.ExpiryDate.toLocaleDateString()} </td>
        <td>
            <button onclick="buy('${medicine.MedicineId}')">Buy</button>
        </td>`;
        purchaseTable.appendChild(row);

    })
}

async function buy(medicineId:string){
    const medicine = MedicineList.find(med => med.MedicineId===medicineId);
    if(medicine){
        let countValue = prompt("Please enter your count:", "0");
        var count:number = Number(countValue);
        {
            if(medicine.MedicineCount>=count)
            {
                if(medicine.ExpiryDate > new Date()){
                    var price = medicine.MedicinePrice*count;
                    if(currentUser.Amount>=price){
                        medicine.MedicineCount-=count;
                        currentUser.Amount-=price;
                        OrderList.push(new Order(medicine.MedicineId,currentUser.UserId,price,medicine.MedicineName,count,new Date(),orderStatus.purchased));
                        alert(`You have successfully purchased ${medicine.MedicineName}. Order ID is ${OrderList[OrderList.length - 1].OrderId}`);
                        order();

                    }
                    else{
                        alert("Insufficient Balance")
                    }
                }
                else{
                    alert("Medicine had Expired")
                }

            }
            else{
                alert("Medicine is out of stock")
            }
        }

    }
    else{
        alert("Medicine not Found")
    }
}

async function order(){
    displayNone();
    orderpage.style.display="block";

    var orderTable = document.getElementById("orderTable") as HTMLTableElement;
    var len = orderTable.getElementsByTagName("tr").length;

    if(orderTable.hasChildNodes()){
        for(var i=len-1;i>=1;i--){
            orderTable.removeChild(orderTable.children[i]);
        }
    }

    OrderList.forEach((order)=>{
        if(order.UserId==currentUser.UserId){
            var row = document.createElement("tr") as HTMLTableRowElement;
            row.innerHTML= `<td>${order.OrderId} <td>${order.UserId}</td> <td>${order.MedicineId}</td> <td>${order.MedicineCount}</td> <td>${order.Total}</td> 
            <td>${order.OrderDate.toLocaleDateString()}</td> <td>${order.PurchaseStatus}</td>
            <td><button id="cancelbtn" onclick="cancelOrder('${order.OrderId}')">Cancel</button></td>`;
            orderTable.appendChild(row);
        }
    })
}

async function cancelOrder(orderId:string){
    var orderData = OrderList.find(o=> o.OrderId==orderId && o.UserId==currentUser.UserId && o.PurchaseStatus== orderStatus.purchased);
    if(orderData){
        orderData.PurchaseStatus=orderStatus.cancelled;
        currentUser.Amount+=orderData.Total;
        var medicineId = orderData.MedicineId;
        var medicine = MedicineList.find(med=> med.MedicineId==medicineId);
        if(medicine){
            medicine.MedicineCount+=orderData.MedicineCount;
        }       
        alert("Order Cancelled Succesfully") 
        order();
    }
    else{
        alert("No Order Found")
    }
}

async function topup(){
    displayNone();
    topuppage.style.display="block";
    (document.getElementById("currentBalance") as HTMLHeadingElement).innerHTML = `Available Balance : ${currentUser.Amount}`;
}

async function deposit(){
    var amount = document.getElementById("amount") as HTMLInputElement;
    if(Number(amount.value)>0){
        currentUser.Amount+= Number(amount.value);
        alert("Amount Deposited Successfully")
    }
    else{
        alert("Invalid Amount")
    }
   
    amount.value ="";
    (document.getElementById("currentBalance") as HTMLHeadingElement).innerHTML = `Available Balance : ${currentUser.Amount}`;
}

async function logout(){
    displayNone();
    (document.getElementById("menu") as HTMLDivElement).style.display="none";
    (document.getElementById("box") as HTMLDivElement).style.display="block";
}
