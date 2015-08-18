/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/


/* Example
var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');
var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)
var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');
div.content = 'Hello, world!';
var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');
var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);
console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {
	var domElement = (function () {
		var domElement = {
			init: function(type) {
        this.type=type;
        this.content='';
        this.parent;
        this.children=[];
        this.attributes=[];
        
        return this;
			},
			appendChild: function(child) {
        this.children.push(child);
        
        if(typeof(child)==='object'){
          child.parent=this;
        }
        
        return this;
			},
			addAttribute: function(name, value) {
         var j,lenA=name.length,flag=true,attr,lenOfAttr=this.attributes.length;
         for (attr = 0; attr < lenOfAttr; attr+=1) {
           if(this.attributes[attr].name===name){
             this.attributes.splice(attr,1);
             lenOfAttr--;
             attr--;
           }
         }
         
        if(!name){
          throw Error;
        }
        
        if(typeof(name)!=='string'){
          throw Error;
        }
        
        for(j=0;j<lenA;j+=1){
          if(name.charAt(j)==='-'){
            flag=false;
          } else if(name.charCodeAt(j)<48 || name.charCodeAt(j)>122){
            throw Error;
            break;
          }else if(name.charCodeAt(j)>57 && name.charCodeAt(j)<65){
            throw Error;
            break;
          }else if(name.charCodeAt(j)>90 && name.charCodeAt(j)<97){
            throw Error;
            break;
          }
        }
        if(flag===false){
          this.attributes.push({name:name,value:value});
        }else {
          this.attributes.push({name:name,value:value}); 
        }   
        return this;
			},
			removeAttribute: function(attribute) {
        var index,lenOfAttributes=this.attributes.length,isInAttributes=false;
        for(index=0;index<lenOfAttributes;index+=1){
          if(this.attributes[index].name===attribute){
            this.attributes.splice(index,1);
            isInAttributes=true;
            lenOfAttributes--;
            index--;
          }
        }
        if(isInAttributes===false){
          throw Error;
        }
        
        return this;
			},
      get children(){
        return this._children;
      },
      set children(value){
        this._children=value;
      },
      get parent(){
        return this._parent;
      },
      set parent(value){
        this._parent=value;
      },
      get content(){
        if(this.children.length){
          return '';
        }
        return this._content;
      },
      set content(value){
        this._content=value;
      },
      get innerHTML(){
       var arrNames=[],i,sortedArr=[],n,k,len1,len2,innerHtml='',child,lenOfChild,c,a,lenOfSort;
       for(i in this.attributes){
         arrNames.push(this.attributes[i].name);
       }

       arrNames.sort();

       len1=arrNames.length;
       len2=this.attributes.length;
      for(n=0;n<len1;n+=1){

        for(k=0;k<len2;k+=1){

          if(arrNames[n]===this.attributes[k].name){
            sortedArr.push(this.attributes[k]);
            break;
          }
        }
      }
      lenOfSort=sortedArr.length;
     innerHtml+='<'+this.type;
     for(a=0;a<lenOfSort;a+=1){
       innerHtml+=' '+sortedArr[a].name+'="'+sortedArr[a].value+'"';
     }
     
     innerHtml+='>';
     
     lenOfChild=this.children.length;
     for(c=0;c<lenOfChild;c+=1){
       child=this.children[c];
       
       if(typeof(child)==='string'){
         innerHtml+=child;
       }else {
         innerHtml+=child.innerHTML;
       }
     }
     
     innerHtml+=this.content;
     innerHtml+='</'+this.type+'>';
     
       return innerHtml;
      },
      get attributes(){
        return this._attributes;
      },
      set attributes(value){
        this._attributes=value;
      },
      get type(){
        return this._type;
      },
      set type(value){
        var i,len=value.length;
        if(!value){
          throw Error;
        }
        
        if(typeof(value)!=='string'){
          throw Error;
        }
        
        for(i=0;i<len;i+=1){
          if(value.charCodeAt(i)<48 || value.charCodeAt(i)>122){
            throw Error;
            break;
          }else if(value.charCodeAt(i)>57 && value.charCodeAt(i)<65){
            throw Error;
            break;
          }else if(value.charCodeAt(i)>90 && value.charCodeAt(i)<97){
            throw Error;
            break;
          }else {
            this._type=value;
            
          }
        }
      }
		};
		return domElement;
	} ());
	return domElement;
}

module.exports = solve;