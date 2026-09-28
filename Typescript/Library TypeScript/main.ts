let autoIncrementBookId: number = 1000;
let autoIncrementUserID: number = 2000;
let autoIncremnetBorrowId: number = 5000;

class UserDetails {
    UserId: string;
    Name: string;

    UserPhoneNumber: string;
    Email: string;
    Password: string;


    Amount: number = 0;

    constructor(name: string, email: string, password: string, paramUserPhoneNumber: string) {

        this.UserId = "UID" + ++autoIncrementUserID;
        this.Name = name;
        this.Email = email;
        this.Password = password;

        this.UserPhoneNumber = paramUserPhoneNumber;
    }
    WalletRecharge(amount: number) {
        this.Amount += amount;
    }

    DeductBalance(amount: number) {
        this.Amount -= amount;
    }
}

class BookDetails {
    BookId: string;
    BookName: string;
    AuthorName: string;
    AvailabiltyStatus: string;

    constructor(bookName: string, authorName: string, availabiltyStatus: string) {
        this.BookId = "BID" + ++autoIncrementBookId;
        this.BookName = bookName;
        this.AuthorName = authorName;
        this.AvailabiltyStatus = availabiltyStatus;
    }
}

class BorrowDetails {
    BorrowId: string;
    UserId: string;
    BookID: string;
    BorrowDate: Date;
    BookinStatus: string;
    FineAmount: number;

    constructor(userID: string, bookId: string, borrowDate: Date, bookingStatus: string, fineAmount: number) {
        this.BorrowId = "BRID" + ++autoIncremnetBorrowId;
        this.UserId = userID;
        this.BookID = bookId;
        this.BorrowDate = borrowDate;
        this.BookinStatus = bookingStatus;
        this.FineAmount = fineAmount;
    }
}

//creating an array for the userdetails to store it 
let UserList: Array<UserDetails> = new Array<UserDetails>();

//adding the information to it
UserList.push(new UserDetails("Edward", "edward@123", "123", "7305541054"));
UserList.push(new UserDetails("Mark", "mark@123", "123", "7305461054"));
UserList.push(new UserDetails("Charu", "charu@123", "123", "7305753054"));
UserList.push(new UserDetails("Subin", "subin@123", "123", "7302361054"));

//creating an array for the Book Details
let BookList: Array<BookDetails> = new Array<BookDetails>();

//adding the book list
BookList.push(new BookDetails("Harry Potter", "JK", "Available"));
BookList.push(new BookDetails("HTML", "Peter Parker", "Borrowed"));
BookList.push(new BookDetails("CSS", "Steve", "Available"));
BookList.push(new BookDetails("JS", "Tony", "Available"));
BookList.push(new BookDetails("Red Book", "Bucky", "Borrowed"));

//creating a array for the borrow details
let BorrowList: Array<BorrowDetails> = new Array<BorrowDetails>();

BorrowList.push(new BorrowDetails("UID2001", "BID1005", new Date(2025, 1, 2), "Borrowed", 100));
BorrowList.push(new BorrowDetails("UID2003", "BID1002", new Date(2024, 4, 23), "Returned", 0));
BorrowList.push(new BorrowDetails("UID2003", "BID1003", new Date(2024, 4, 15), "Returned", 0));
BorrowList.push(new BorrowDetails("UID2004", "BID1001", new Date(2024, 4, 3), "Damaged", 500));



var currentUser: UserDetails;






var signInForm = document.getElementById("signIn") as HTMLDivElement;
var signUpForm = document.getElementById("signUp") as HTMLDivElement;
var signInButton = document.getElementById("signInButton") as HTMLDivElement;
var signUpButton = document.getElementById("signUpButton") as HTMLDivElement;


function signIn(): void {
    signInForm.style.display = "block";
    signUpForm.style.display = "none";
    signInButton.style.background = "orange";
    signUpButton.style.background = "none";
}

function signUp(): void {
    signInForm.style.display = "none";
    signUpForm.style.display = "block";
    signInButton.style.background = "none";
    signUpButton.style.background = "orange";
}

async function signUpSubmit(e) {
    e.preventDefault();

    var name = document.getElementById("name") as HTMLInputElement;
    var email = document.getElementById("email") as HTMLInputElement;
    var password = document.getElementById("password") as HTMLInputElement;
    var cpassword = document.getElementById("cpassword") as HTMLInputElement;
    var phone = document.getElementById("phone") as HTMLInputElement;

    var isAvail: boolean = true;
    UserList.forEach((val) => {
        if (val.Email.toLowerCase() == email.value.toLowerCase()) {
            alert("You're Already a Active User")
            isAvail = false;
        }
    });

    if (isAvail) {
        let user: UserDetails = new UserDetails(name.value, email.value, password.value, phone.value);
        UserList.push(user);
        alert("You'r User Id is" + user.UserId)
        isAvail = false;
    }
    else {
        var i = document.getElementById("signUp") as HTMLDivElement;
        i.style.border = "5px solid red";
    }
}

async function signInSubmit(e) {
    e.preventDefault();

    var isAvail: boolean = true;
    var email2 = document.getElementById("email1") as HTMLInputElement;
    var password2 = document.getElementById("password2") as HTMLInputElement;

    UserList.forEach((val) => {
        if (val.Email.toLowerCase() == email2.value && val.Password == password2.value) {
            var bx = document.getElementById("box") as HTMLDivElement;
            var menu = document.getElementById("menu") as HTMLDivElement;

            bx.style.display = "none";
            menu.style.display = "block";
            isAvail = false;
            currentUser = val;
            home();
            email2.value = "";
            password2.value = "";
        }

    });
}
let homepage = document.getElementById("homepage") as HTMLDivElement;
let bookDetailsPage = document.getElementById("bookDetailsPage") as HTMLDivElement;
let borrorBookPage = document.getElementById("borrorBookPage") as HTMLDivElement;
let borrorHistoryPage = document.getElementById("borrorHistoryPage") as HTMLDivElement;
let returnPage = document.getElementById("returnPage") as HTMLDivElement;
let topUpPage = document.getElementById("topUpPage") as HTMLDivElement;
async function home() {
    displayNone();
    homepage.style.display = "block";
    var welcome = document.getElementById("welcome") as HTMLHeadingElement;
    welcome.innerHTML = "Welcome" + currentUser.Name;

}

async function displayNone() {
    homepage.style.display = "none";
    bookDetailsPage.style.display = "none";
    borrorBookPage.style.display = "none";
    borrorHistoryPage.style.display = "none";
    returnPage.style.display = "none";
    topUpPage.style.display = "none";
    (document.getElementById("addEditBookForm") as HTMLDivElement).style.display = "none";
}

async function bookDetails() {
    displayNone();
    bookDetailsPage.style.display = "block";

    var bookDetailsTable = document.getElementById("bookDetailsTable") as HTMLTableElement;
    var len = bookDetailsTable.getElementsByTagName("tr").length;

    if (bookDetailsTable.hasChildNodes()) {
        for (var i = len - 1; i >= 1; i--) {
            bookDetailsTable.removeChild(bookDetailsTable.children[i]);
        }
    }

    BookList.forEach((book) => {
        var row = document.createElement("tr") as HTMLTableRowElement;
        row.innerHTML = `<td>${book.BookId} </td>  <td> ${book.BookName} </td> <td> ${book.AuthorName} </td> <td>${book.AvailabiltyStatus} </td> 
        
        <td>
            <button onclick="editBook('${book.BookId}')">Edit</button>
            <button onclick="deleteBook('${book.BookId}')">Delete</button>
        </td>`;
        bookDetailsTable.appendChild(row);
    });

}

let editBookID: string;

async function deleteBook(bookID: string) {
    var index = BookList.findIndex((val) => val.BookId == bookID);
    BookList.splice(index, 1);
    bookDetails();
}

async function addBook(bookID: string) {
    (document.getElementById("addEditBookForm") as HTMLDivElement).style.display = "block";
    editBookID = "";
}

async function editBook(bookId: string) {
    (document.getElementById("addEditBookForm") as HTMLDivElement).style.display = "block";
    var book = BookList.find((val) => val.BookId == bookId);
    if (book) {
        var bookName = document.getElementById("bookName") as HTMLInputElement;
        var authorName = document.getElementById("authorName") as HTMLInputElement;
        var availability = document.getElementById("availability") as HTMLInputElement;
        bookName.value = book.BookName;
        authorName.value = book.AuthorName.toString();
        availability.value = book.AvailabiltyStatus.toString();
        editBookID = book.BookId;
    }

}

async function addEditBook() {
    var bookName = document.getElementById("bookName") as HTMLInputElement;
    var authorName = document.getElementById("authorName") as HTMLInputElement;
    var availability = document.getElementById("availability") as HTMLInputElement;
    var bookData = BookList.find((val) => val.BookId == editBookID);

    if(bookData) {
        bookData.BookName=bookName.value;
        bookData.AuthorName=authorName.value;
        bookData.AvailabiltyStatus=availability.value;
        alert("book added successfull");
        editBookID="";
    }

    else{
        if(bookName.value.trim() != ""){
            BookList.push(new BookDetails(bookName.value,authorName.value,availability.value));
            alert("Book Details added succesfully");
            editBookID="";
        }
    }
    bookName.value = "";
    authorName.value = "";
    availability.value = "";
    bookDetails();
}

async function borrowBook(){
    displayNone();
    borrorBookPage.style.display="block"

    var borrowBookTable = document.getElementById("borrowBookTable") as HTMLTableElement;
    var len = borrowBookTable.getElementsByTagName("tr").length;

    if (borrowBookTable.hasChildNodes()) {
        for (var i = len - 1; i >= 1; i--) {
            borrowBookTable.removeChild(borrowBookTable.children[i]);
        }
    }

    BookList.forEach((book) => {
        var row = document.createElement("tr") as HTMLTableRowElement;
        row.innerHTML = `<td>${book.BookId} </td>  <td> ${book.BookName} </td> <td> ${book.AuthorName} </td> <td>${book.AvailabiltyStatus} </td> 
        
        <td>
            <button onclick="editBook('${book.BookId}')">Edit</button>
            <button onclick="deleteBook('${book.BookId}')">Delete</button>
        </td>`;
        borrowBookTable.appendChild(row);
    });


}

async function borrowHistory(){
    displayNone();
    borrorHistoryPage.style.display="block";

    var borrowHistoryTable = document.getElementById("borrowHistoryTable") as HTMLTableElement;
    var len = borrowHistoryTable.getElementsByTagName("tr").length;

    if (borrowHistoryTable.hasChildNodes()) {
        for (var i = len - 1; i >= 1; i--) {
            borrowHistoryTable.removeChild(borrowHistoryTable.children[i]);
        }
    }


    BorrowList.forEach((book) => {

        if(book.UserId==currentUser.UserId){
            var row = document.createElement("tr") as HTMLTableRowElement;
        row.innerHTML = `<td>${book.BorrowId} </td>  <td> ${book.BookID} </td> <td> ${book.UserId} </td> <td>${book.BorrowDate.toLocaleDateString()} </td> 
        
        <td>
            ${book.FineAmount}
        </td>`;
        borrowHistoryTable.appendChild(row);
        }
    });
}

async function returnBook(){
    displayNone();
    returnPage.style.display="block";
    var returnTable = document.getElementById("returnTable") as HTMLTableElement;
    var len = returnTable.getElementsByTagName("tr").length;

    if (returnTable.hasChildNodes()) {
        for (var i = len - 1; i >= 1; i--) {
            returnTable.removeChild(returnTable.children[i]);
        }
    }

    BorrowList.forEach((br)=>{
        if(br.UserId==currentUser.UserId && br.BookinStatus.toLocaleLowerCase()=="borrowed"){
            var row = document.createElement("tr") as HTMLTableRowElement;
            row.innerHTML =  `<td>${br.BorrowId}</td>  <td>${br.BookID}</td>  <td>${br.UserId}</td>   <td>${br.BorrowDate.toLocaleDateString()}</td>  <td>${br.FineAmount}</td>
            <td><button id-"returnbtn onclick="returnParticularBook('${br.BorrowId}')">Return</button></td>
            `;
            returnTable.appendChild(row);
        }
    })

}



async function returnParticularBook(borrowID : string){
    BorrowList.forEach((br)=>{
        let newDate;
        let fineAmount =0;
        if(br.BorrowId==borrowID){
            newDate = addDays(br.BorrowDate,15);
            
            
            if(newDate <= new Date()){
                let isDamaged = prompt("Book Damaged")?.toLocaleLowerCase();
                if(isDamaged=="yes"){
                    fineAmount+=300;
                    if(currentUser.Amount<fineAmount){
                        alert("Insufficient Balance");
                    }
                    else{
                        currentUser.Amount-=fineAmount;
                        br.BookinStatus="Returned";
                        alert("Book returned succesfully");
                    }
                }
                else{
                    br.BookinStatus="Returned";
                    alert("Book returned succesfully");
                }
            }
        }
        else{
            let days = newDate.getDate()-new Date().getDate();
            fineAmount+=days;
            let isDamaged = prompt("Book is Damaged")?.toLowerCase()
            if(isDamaged=="yes"){
                fineAmount+=300;
                if(currentUser.Amount<fineAmount){
                    alert("Insufficient Balance");
                }
                else{
                    currentUser.Amount-=fineAmount;
                    br.BookinStatus="Returned";
                    alert("Book returned succesfully");
                }
            }
            else{
                br.BookinStatus="Returned";
                alert("Book returned succesfully");
            }
        }
    })
}

async function topup(){
    displayNone();
    topUpPage.style.display="block";
    (document.getElementById("currentBalance") as HTMLHeadingElement).innerHTML = `Available Balance:${currentUser.Amount}`;

}

async function deposit(){
    var amount = document.getElementById("amount") as HTMLInputElement;
    currentUser.WalletRecharge(Number(amount.value));
    alert("Amount Added");
    amount.value="";
    (document.getElementById("currentBalance") as HTMLHeadingElement).innerHTML = `Available Balance: ${currentUser.Amount}`;

}

async function logout(){
    displayNone();
    (document.getElementById("menu") as HTMLDivElement).style.display="none";
    (document.getElementById("box") as HTMLDivElement).style.display="block";
}

function addDays(BorrowDate: Date, arg1: number) {
    throw new Error("Function not implemented.");
}
