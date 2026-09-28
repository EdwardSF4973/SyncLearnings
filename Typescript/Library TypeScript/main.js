var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g = Object.create((typeof Iterator === "function" ? Iterator : Object).prototype);
    return g.next = verb(0), g["throw"] = verb(1), g["return"] = verb(2), typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (g && (g = 0, op[0] && (_ = 0)), _) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
var autoIncrementBookId = 1000;
var autoIncrementUserID = 2000;
var autoIncremnetBorrowId = 5000;
var UserDetails = /** @class */ (function () {
    function UserDetails(name, email, password, paramUserPhoneNumber) {
        this.Amount = 0;
        this.UserId = "UID" + ++autoIncrementUserID;
        this.Name = name;
        this.Email = email;
        this.Password = password;
        this.UserPhoneNumber = paramUserPhoneNumber;
    }
    UserDetails.prototype.WalletRecharge = function (amount) {
        this.Amount += amount;
    };
    UserDetails.prototype.DeductBalance = function (amount) {
        this.Amount -= amount;
    };
    return UserDetails;
}());
var BookDetails = /** @class */ (function () {
    function BookDetails(bookName, authorName, availabiltyStatus) {
        this.BookId = "BID" + ++autoIncrementBookId;
        this.BookName = bookName;
        this.AuthorName = authorName;
        this.AvailabiltyStatus = availabiltyStatus;
    }
    return BookDetails;
}());
var BorrowDetails = /** @class */ (function () {
    function BorrowDetails(userID, bookId, borrowDate, bookingStatus, fineAmount) {
        this.BorrowId = "BRID" + ++autoIncremnetBorrowId;
        this.UserId = userID;
        this.BookID = bookId;
        this.BorrowDate = borrowDate;
        this.BookinStatus = bookingStatus;
        this.FineAmount = fineAmount;
    }
    return BorrowDetails;
}());
//creating an array for the userdetails to store it 
var UserList = new Array();
//adding the information to it
UserList.push(new UserDetails("Edward", "edward@123", "123", "7305541054"));
UserList.push(new UserDetails("Mark", "mark@123", "123", "7305461054"));
UserList.push(new UserDetails("Charu", "charu@123", "123", "7305753054"));
UserList.push(new UserDetails("Subin", "subin@123", "123", "7302361054"));
//creating an array for the Book Details
var BookList = new Array();
//adding the book list
BookList.push(new BookDetails("Harry Potter", "JK", "Available"));
BookList.push(new BookDetails("HTML", "Peter Parker", "Borrowed"));
BookList.push(new BookDetails("CSS", "Steve", "Available"));
BookList.push(new BookDetails("JS", "Tony", "Available"));
BookList.push(new BookDetails("Red Book", "Bucky", "Borrowed"));
//creating a array for the borrow details
var BorrowList = new Array();
BorrowList.push(new BorrowDetails("UID2001", "BID1005", new Date(2025, 1, 2), "Borrowed", 100));
BorrowList.push(new BorrowDetails("UID2003", "BID1002", new Date(2024, 4, 23), "Returned", 0));
BorrowList.push(new BorrowDetails("UID2003", "BID1003", new Date(2024, 4, 15), "Returned", 0));
BorrowList.push(new BorrowDetails("UID2004", "BID1001", new Date(2024, 4, 3), "Damaged", 500));
var currentUser;
var signInForm = document.getElementById("signIn");
var signUpForm = document.getElementById("signUp");
var signInButton = document.getElementById("signInButton");
var signUpButton = document.getElementById("signUpButton");
function signIn() {
    signInForm.style.display = "block";
    signUpForm.style.display = "none";
    signInButton.style.background = "orange";
    signUpButton.style.background = "none";
}
function signUp() {
    signInForm.style.display = "none";
    signUpForm.style.display = "block";
    signInButton.style.background = "none";
    signUpButton.style.background = "orange";
}
function signUpSubmit(e) {
    return __awaiter(this, void 0, void 0, function () {
        var name, email, password, cpassword, phone, isAvail, user, i;
        return __generator(this, function (_a) {
            e.preventDefault();
            name = document.getElementById("name");
            email = document.getElementById("email");
            password = document.getElementById("password");
            cpassword = document.getElementById("cpassword");
            phone = document.getElementById("phone");
            isAvail = true;
            UserList.forEach(function (val) {
                if (val.Email.toLowerCase() == email.value.toLowerCase()) {
                    alert("You're Already a Active User");
                    isAvail = false;
                }
            });
            if (isAvail) {
                user = new UserDetails(name.value, email.value, password.value, phone.value);
                UserList.push(user);
                alert("You'r User Id is" + user.UserId);
                isAvail = false;
            }
            else {
                i = document.getElementById("signUp");
                i.style.border = "5px solid red";
            }
            return [2 /*return*/];
        });
    });
}
function signInSubmit(e) {
    return __awaiter(this, void 0, void 0, function () {
        var isAvail, email2, password2;
        return __generator(this, function (_a) {
            e.preventDefault();
            isAvail = true;
            email2 = document.getElementById("email1");
            password2 = document.getElementById("password2");
            UserList.forEach(function (val) {
                if (val.Email.toLowerCase() == email2.value && val.Password == password2.value) {
                    var bx = document.getElementById("box");
                    var menu = document.getElementById("menu");
                    bx.style.display = "none";
                    menu.style.display = "block";
                    isAvail = false;
                    currentUser = val;
                    home();
                    email2.value = "";
                    password2.value = "";
                }
            });
            return [2 /*return*/];
        });
    });
}
var homepage = document.getElementById("homepage");
var bookDetailsPage = document.getElementById("bookDetailsPage");
var borrorBookPage = document.getElementById("borrorBookPage");
var borrorHistoryPage = document.getElementById("borrorHistoryPage");
var returnPage = document.getElementById("returnPage");
var topUpPage = document.getElementById("topUpPage");
function home() {
    return __awaiter(this, void 0, void 0, function () {
        var welcome;
        return __generator(this, function (_a) {
            displayNone();
            homepage.style.display = "block";
            welcome = document.getElementById("welcome");
            welcome.innerHTML = "Welcome" + currentUser.Name;
            return [2 /*return*/];
        });
    });
}
function displayNone() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            homepage.style.display = "none";
            bookDetailsPage.style.display = "none";
            borrorBookPage.style.display = "none";
            borrorHistoryPage.style.display = "none";
            returnPage.style.display = "none";
            topUpPage.style.display = "none";
            document.getElementById("addEditBookForm").style.display = "none";
            return [2 /*return*/];
        });
    });
}
function bookDetails() {
    return __awaiter(this, void 0, void 0, function () {
        var bookDetailsTable, len, i;
        return __generator(this, function (_a) {
            displayNone();
            bookDetailsPage.style.display = "block";
            bookDetailsTable = document.getElementById("bookDetailsTable");
            len = bookDetailsTable.getElementsByTagName("tr").length;
            if (bookDetailsTable.hasChildNodes()) {
                for (i = len - 1; i >= 1; i--) {
                    bookDetailsTable.removeChild(bookDetailsTable.children[i]);
                }
            }
            BookList.forEach(function (book) {
                var row = document.createElement("tr");
                row.innerHTML = "<td>".concat(book.BookId, " </td>  <td> ").concat(book.BookName, " </td> <td> ").concat(book.AuthorName, " </td> <td>").concat(book.AvailabiltyStatus, " </td> \n        \n        <td>\n            <button onclick=\"editBook('").concat(book.BookId, "')\">Edit</button>\n            <button onclick=\"deleteBook('").concat(book.BookId, "')\">Delete</button>\n        </td>");
                bookDetailsTable.appendChild(row);
            });
            return [2 /*return*/];
        });
    });
}
var editBookID;
function deleteBook(bookID) {
    return __awaiter(this, void 0, void 0, function () {
        var index;
        return __generator(this, function (_a) {
            index = BookList.findIndex(function (val) { return val.BookId == bookID; });
            BookList.splice(index, 1);
            bookDetails();
            return [2 /*return*/];
        });
    });
}
function addBook(bookID) {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            document.getElementById("addEditBookForm").style.display = "block";
            editBookID = "";
            return [2 /*return*/];
        });
    });
}
function editBook(bookId) {
    return __awaiter(this, void 0, void 0, function () {
        var book, bookName, authorName, availability;
        return __generator(this, function (_a) {
            document.getElementById("addEditBookForm").style.display = "block";
            book = BookList.find(function (val) { return val.BookId == bookId; });
            if (book) {
                bookName = document.getElementById("bookName");
                authorName = document.getElementById("authorName");
                availability = document.getElementById("availability");
                bookName.value = book.BookName;
                authorName.value = book.AuthorName.toString();
                availability.value = book.AvailabiltyStatus.toString();
                editBookID = book.BookId;
            }
            return [2 /*return*/];
        });
    });
}
function addEditBook() {
    return __awaiter(this, void 0, void 0, function () {
        var bookName, authorName, availability, bookData;
        return __generator(this, function (_a) {
            bookName = document.getElementById("bookName");
            authorName = document.getElementById("authorName");
            availability = document.getElementById("availability");
            bookData = BookList.find(function (val) { return val.BookId == editBookID; });
            if (bookData) {
                bookData.BookName = bookName.value;
                bookData.AuthorName = authorName.value;
                bookData.AvailabiltyStatus = availability.value;
                alert("book added successfull");
                editBookID = "";
            }
            else {
                if (bookName.value.trim() != "") {
                    BookList.push(new BookDetails(bookName.value, authorName.value, availability.value));
                    alert("Book Details added succesfully");
                    editBookID = "";
                }
            }
            bookName.value = "";
            authorName.value = "";
            availability.value = "";
            bookDetails();
            return [2 /*return*/];
        });
    });
}
function borrowBook() {
    return __awaiter(this, void 0, void 0, function () {
        var borrowBookTable, len, i;
        return __generator(this, function (_a) {
            displayNone();
            borrorBookPage.style.display = "block";
            borrowBookTable = document.getElementById("borrowBookTable");
            len = borrowBookTable.getElementsByTagName("tr").length;
            if (borrowBookTable.hasChildNodes()) {
                for (i = len - 1; i >= 1; i--) {
                    borrowBookTable.removeChild(borrowBookTable.children[i]);
                }
            }
            BookList.forEach(function (book) {
                var row = document.createElement("tr");
                row.innerHTML = "<td>".concat(book.BookId, " </td>  <td> ").concat(book.BookName, " </td> <td> ").concat(book.AuthorName, " </td> <td>").concat(book.AvailabiltyStatus, " </td> \n        \n        <td>\n            <button onclick=\"editBook('").concat(book.BookId, "')\">Edit</button>\n            <button onclick=\"deleteBook('").concat(book.BookId, "')\">Delete</button>\n        </td>");
                borrowBookTable.appendChild(row);
            });
            return [2 /*return*/];
        });
    });
}
function borrowHistory() {
    return __awaiter(this, void 0, void 0, function () {
        var borrowHistoryTable, len, i;
        return __generator(this, function (_a) {
            displayNone();
            borrorHistoryPage.style.display = "block";
            borrowHistoryTable = document.getElementById("borrowHistoryTable");
            len = borrowHistoryTable.getElementsByTagName("tr").length;
            if (borrowHistoryTable.hasChildNodes()) {
                for (i = len - 1; i >= 1; i--) {
                    borrowHistoryTable.removeChild(borrowHistoryTable.children[i]);
                }
            }
            BorrowList.forEach(function (book) {
                if (book.UserId == currentUser.UserId) {
                    var row = document.createElement("tr");
                    row.innerHTML = "<td>".concat(book.BorrowId, " </td>  <td> ").concat(book.BookID, " </td> <td> ").concat(book.UserId, " </td> <td>").concat(book.BorrowDate.toLocaleDateString(), " </td> \n        \n        <td>\n            ").concat(book.FineAmount, "\n        </td>");
                    borrowHistoryTable.appendChild(row);
                }
            });
            return [2 /*return*/];
        });
    });
}
function returnBook() {
    return __awaiter(this, void 0, void 0, function () {
        var returnTable, len, i;
        return __generator(this, function (_a) {
            displayNone();
            returnPage.style.display = "block";
            returnTable = document.getElementById("returnTable");
            len = returnTable.getElementsByTagName("tr").length;
            if (returnTable.hasChildNodes()) {
                for (i = len - 1; i >= 1; i--) {
                    returnTable.removeChild(returnTable.children[i]);
                }
            }
            BorrowList.forEach(function (br) {
                if (br.UserId == currentUser.UserId && br.BookinStatus.toLocaleLowerCase() == "borrowed") {
                    var row = document.createElement("tr");
                    row.innerHTML = "<td>".concat(br.BorrowId, "</td>  <td>").concat(br.BookID, "</td>  <td>").concat(br.UserId, "</td>   <td>").concat(br.BorrowDate.toLocaleDateString(), "</td>  <td>").concat(br.FineAmount, "</td>\n            <td><button id-\"returnbtn onclick=\"returnParticularBook('").concat(br.BorrowId, "')\">Return</button></td>\n            ");
                    returnTable.appendChild(row);
                }
            });
            return [2 /*return*/];
        });
    });
}
function returnParticularBook(borrowID) {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            BorrowList.forEach(function (br) {
                var _a, _b;
                var newDate;
                var fineAmount = 0;
                if (br.BorrowId == borrowID) {
                    newDate = addDays(br.BorrowDate, 15);
                    if (newDate <= new Date()) {
                        var isDamaged = (_a = prompt("Book Damaged")) === null || _a === void 0 ? void 0 : _a.toLocaleLowerCase();
                        if (isDamaged == "yes") {
                            fineAmount += 300;
                            if (currentUser.Amount < fineAmount) {
                                alert("Insufficient Balance");
                            }
                            else {
                                currentUser.Amount -= fineAmount;
                                br.BookinStatus = "Returned";
                                alert("Book returned succesfully");
                            }
                        }
                        else {
                            br.BookinStatus = "Returned";
                            alert("Book returned succesfully");
                        }
                    }
                }
                else {
                    var days = newDate.getDate() - new Date().getDate();
                    fineAmount += days;
                    var isDamaged = (_b = prompt("Book is Damaged")) === null || _b === void 0 ? void 0 : _b.toLowerCase();
                    if (isDamaged == "yes") {
                        fineAmount += 300;
                        if (currentUser.Amount < fineAmount) {
                            alert("Insufficient Balance");
                        }
                        else {
                            currentUser.Amount -= fineAmount;
                            br.BookinStatus = "Returned";
                            alert("Book returned succesfully");
                        }
                    }
                    else {
                        br.BookinStatus = "Returned";
                        alert("Book returned succesfully");
                    }
                }
            });
            return [2 /*return*/];
        });
    });
}
function topup() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            displayNone();
            topUpPage.style.display = "block";
            document.getElementById("currentBalance").innerHTML = "Available Balance:".concat(currentUser.Amount);
            return [2 /*return*/];
        });
    });
}
function deposit() {
    return __awaiter(this, void 0, void 0, function () {
        var amount;
        return __generator(this, function (_a) {
            amount = document.getElementById("amount");
            currentUser.WalletRecharge(Number(amount.value));
            alert("Amount Added");
            amount.value = "";
            document.getElementById("currentBalance").innerHTML = "Available Balance: ".concat(currentUser.Amount);
            return [2 /*return*/];
        });
    });
}
function logout() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            displayNone();
            document.getElementById("menu").style.display = "none";
            document.getElementById("box").style.display = "block";
            return [2 /*return*/];
        });
    });
}
function addDays(BorrowDate, arg1) {
    throw new Error("Function not implemented.");
}
