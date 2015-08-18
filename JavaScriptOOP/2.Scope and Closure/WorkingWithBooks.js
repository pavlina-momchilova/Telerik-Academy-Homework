/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];
		function listBooks(property) {
			
			return books;
		}

		function addBook(book) {
			var index,
			i,
			len = books.length,
			isbnLen = book.isbn.length,
			flag=false;
			
			if(book.title && (book.title.length < 2 || book.title.length > 100)){
				throw Error;
			}
			
			if(book.category && (book.category.length < 2 || book.category.length > 100)){
				throw Error;
			}
			
			if(!book.author){
				throw Error;
			}
			
			for (index = 0; index < len; index+=1) {
				if(books[index].title===book.title){
					throw Error;
				}
				if(books[index].isbn===book.isbn){
					throw Error;
				}
				if(books[index].category===book.category){
					flag=true;
				}
			}
			
			if(!flag){
				var newCategory= {
					category:book.category,
					ID: categories.length + 2
				}
				categories.push(newCategory);
			}
			
			if(book.isbn.length!==10 && book.isbn.length!==13){
				throw Error;
			}
			
			for(i = 0; i < isbnLen; i += 1){
				if(book.isbn[i] < 48 || book.isbn[i] > 57){
					throw Error;
				}
			}
			
			
			book.ID = books.length + 2;
			
			books.push(book);
			
			return book;
		}

		function listCategories() {
			return categories.sort(function(a,b){return a.ID-b.ID})
			.map(function(item){item=item.name;return item;});
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;