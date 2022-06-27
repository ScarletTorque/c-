class Node {
    constructor(value, next = null, previous = null) {
        this.value = value;
        this.next = next;
        this.previous = previous;
    }
}

class DLList {
    constructor() {
        this.head = null;
        this.tail = null;
        this.size = 0;
    }

    printValues() {
        // step #0 [EDGE CASE]) handle a case where there is nothing in the list
        if (this.head == null) {
            console.log("There's nothing in the list! Dummy!")
            // return 'this' to end function and allow chaining of methods
            return this
        }
        //step #1) establish a runner to traverse through the list
        var runner = this.head;

        // NOTE: we can move runner all the way into null because our loop will exit as soon as runner hits null, avoiding any errors with printing
        while (runner != null) {
            // step #2) print the values at each iteration before moving the runner!
            console.log(`The current value is: ${runner.value}`)
            runner = runner.next
        }
        console.log("We have hit the end of the list!")
        // return 'this' to end function and allow chaining of methods
        return this
    }


    // Insert at Front
    // Insert a given value to the front of the doubly linked list
    InsertAtFront(val) {
        let node = new Node(val);
        if (!this.head && !this.tail) {
            this.head = node;
            this.tail = node;
            return this;
        }
        node.next = this.head;
        this.head.prev = node;
        this.head = node;
        return this;
    }

    InsertAtBack(val) {
        let node = new Node(val);
        if (!this.head && !this.tail) {
            this.head = node;
            this.tail = node;
            return this;
        }
        node.prev = this.tail;
        this.tail.next = node;
        this.tail = node;
        return this;
    }

    RemoveMiddle() {
        let start = this.head;
        let end = this.tail;
        if(!start && !end){
            return this;
        }
        else if(start.next == end){
            this.head = this.tail;
            this.tail.prev = null;
            return this;
        }
        else if(start == end){
            this.head = null;
            this.tail = null;
            return this;
        }
        while(start !== end){
            start = start.next;
            end = end.prev;
        }
        start.prev.next = end.next;
        end.next.prev = start.prev;
        return this;
    }

}

var dll = new DLList();


dll.InsertAtFront(1).InsertAtFront(2).InsertAtFront(3).InsertAtFront(4);
dll.printValues()