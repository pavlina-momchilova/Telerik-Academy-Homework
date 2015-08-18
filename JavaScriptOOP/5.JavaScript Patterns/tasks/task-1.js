/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
  function titleValidation(title){
    var i,lenOfTitle=title.length,tit,j;
    
    if(!title){
      throw Error;
    }
      
    if(typeof(title)==='string'){
      if(lenOfTitle<1){
        throw Error;
      }
    
      if(title[0]===' ' || title[lenOfTitle-1]===' '){
        throw Error;
      }
    
      for(i=0;i<lenOfTitle-1;i+=1){
        if(title[i]===' ' && title[i+1]===' '){
          throw Error;
        }
      }
      
    }else{
      for(tit=0;tit<lenOfTitle;tit+=1){
        var lenOfSingTit=title[tit].length;
        
        if(lenOfSingTit<1){
          throw Error;
        }
        
        if(title[tit][0]===' ' || title[tit][lenOfTitle-1]===' '){
          throw Error;
        }
        
        for(j=0;j<lenOfSingTit;j+=1){
          if(title[tit][j]===' ' && title[tit][j+1]===' '){
            throw Error;
          }
        }
      }
    }
  }
  
  function nameValidation(name){
    var i,lenOfName=name.length;
    if(name.charCodeAt(0)<65 || name.charCodeAt(0)>90){
      throw Error;
    }
    
    if(lenOfName>1){
      for(i=1;i<lenOfName;i+=1){
        if(name.charCodeAt(i)<97 || name.charCodeAt(i)>122){
          throw Error;
        }
      }
    }
  }
  
  
  /*******************************************************************************************/
	
  var Course = {
		init: function(title, presentations) {
     
      titleValidation(title);
      titleValidation(presentations);
      this.title=title;
      this.presentations=presentations;

      this.students=[];
      
      return this;
		},
		addStudent: function(name) {
      var splitedName=name.split(' '),studentID;
      if(splitedName.length!==2){
        throw Error;
      }
      nameValidation(splitedName[0]);
      nameValidation(splitedName[1]);
      
     
      studentID=this.students.length+1;
      this.students.push({firstname:splitedName[0],lastname:splitedName[1],id:studentID});
      
      return studentID;
		},
		getAllStudents: function() {
      return this.students.slice();
		},
		submitHomework: function(studentID, homeworkID) {
      var lenOfStud=this.students.length, lenOfPresentations=this.presentations.length,k,l;
      if(studentID>lenOfStud){
        throw Error;
      }
    
      if(homeworkID>lenOfPresentations){
        throw Error;
      }
      
      
      if(!studentID || !homeworkID){
        throw Error;
      }
      
      if(studentID<=0 || homeworkID<=0){
        throw Error;
      }
      
      if((studentID/Math.round(studentID))!==1){
        throw Error;
      }
      
      if((homeworkID/Math.round(homeworkID))!==1){
        throw Error;
      }
      
      return this;
		},
		pushExamResults: function(results) {
      var student,res,lenOfS=this.students.length,lenOfR=results.length,flag=false;
      if(!results){
        throw Error;
      }
      
      if(!(results instanceof Array)){
        throw Error;
      }
      
      for(student=0;student<lenOfS;student+=1){
        for(res=0;res<lenOfR;res+=1){
          if(results[res].StudentID>lenOfS){
            throw Error;
          }
          if(typeof(results[res].Score)!=='number'){
            throw Error;
          }
          if(this.students[student].id===results[res].StudentID){
            flag=true;
            break;
          }
        }
      }
      
      if(flag===false){
        throw Error;
      }
      
      return this;
		},
		getTopStudents: function() {
      console.log(this.students);
		},
    get title(){
      return this._title;
    },
    set title(value){
      this._title=value;
    },
    get presentations(){
      return this._presentations;
    },
    set presentations(value){
      if(value.length===0){
        throw Error;
      }
      
      this._presentations=value;
    },
    get students(){
      return this._students;
    },
    set students(value){
      this._students=value;
    }
	};

	return Course;
}


module.exports = solve;
