// Binary Search Tree

// Nodes
class Node {
    constructor(val) {
        this.data = val;
        // All smaller values go to the left
        this.left = null;
        // All larger values go to the right
        this.right = null;
    }
}

class BST {
    constructor() {
        // This is the same as SLLs head pointer
        // All trees start at the root
        this.root = null;
    }

    // Is our tree empty?
    isEmpty() {
        return this.root == null;
    }

    // We can find the min very quickly
    min() {
        // Start at the root
        var runner = this.root;
        // Keep going left until we find null
        while (runner.left) {
            runner = runner.left;
        }
        // The node right before null is our value
        return runner.data;
    }

    // We can find the max very quickly
    max() {
        // Start at the root
        var runner = this.root;
        // Keep going right until we find null
        while (runner.right) {
            runner = runner.right;
        }
        // The node right before null is our value
        return runner.data;
    }

    contains(val) {
        if (this.isEmpty()) {
            return false;
        }
        var runner = this.root;
        while (runner) {
            if (val == runner.data) {
                return true;
            } else if (val < runner.data) {
                runner = runner.left;
            } else {
                runner = runner.right;
            }
        }
        return false;
    }

    recContains(val, runner = this.root) {
        if (this.isEmpty()) {
            return false;
        }
        if (val == runner.data) {
            return true;
        }
        if (!runner.left && !runner.right) {
            return false;
        }
        if (val < runner.data) {
            return this.recContains(val, runner.left);
        } else {
            return this.recContains(val, runner.right);
        }
    }

    range() {
        return this.max() - this.min();
    }

    // Given a value, insert it into the correct location in the binary search tree
    insert(val) {
        let runner = this.root;
        // If our tree is empty create a new root
        if (!runner) {
            this.root = new Node(val);
            return;
        }
        while (true) {
            if (val > runner.data) {
                if (!runner.right) {
                    runner.right = new Node(val);
                    return;
                }
                else {
                    runner = runner.right;
                }
            }
            else if (val < runner.data) {
                if (!runner.left) {
                    runner.left = new Node(val);
                    return;
                }
                else {
                    runner = runner.left;
                }
            }
            else {
                let temp = runner;
                runner = runner.left;
                temp.left = new Node(val);
                temp.left.left = runner;
                return;
            }
        }
    }

    //insert value recursively
    recursiveInsert(val, runner = this.root, prevRunner = this.root) {
        if (this.isEmpty()) {
            this.root = new Node(val);
            return this;
        }

        if (runner) {
            if (val > runner.data) {
                return this.recursiveInsert(val, runner.right, prevRunner = runner);
            } else {
                return this.recursiveInsert(val, runner.left, prevRunner = runner);
            }
        }

        if (val > prevRunner.data) {
            prevRunner.right = new Node(val);
        } else {
            prevRunner.left = new Node(val);
        }

        return this;
    }


    // Size
    // Return the total number of nodes in the tree
    size(runner = this.root) {
        if (runner == null) {
            return 0;
        }
        return 1 + this.size(runner.left) + this.size(runner.right);
    }

    // Height
    // Return the number of nodes that make up the longest branch in a tree
    height2(node = this.root) {
        if (!node) {
            return 0;
        }
        let leftHeight = this.height2(node.left);
        let rightHeight = this.height2(node.right);
        if (leftHeight > rightHeight) {
            return leftHeight + 1
        } else {
            return rightHeight + 1;
        }
    }

    // isFull
    // Return true or false whether every node has either 0 or 2 children
    isFull(node = this.root) {
        // If empty tree
        if (!node) {
            return false;
        }

        // if leaf node, leaf node is the end which means it has no left or right
        if (!node.left && !node.right) {
            return true;
        }

        // if both left and right subtrees are not null and
        // both left and right subtrees are full
        if (node.left && node.right) {
            return this.isFull(node.left) && this.isFull(node.right);
        }
        return false;
    }

    PreOrder(runner = this.root, arr = []){
        //If oour BST is empty array
        if(!runner){
            return arr;
        }

        arr.push(runner.data);
        //If we hit last node of branch push to array
        if(!runner.left && !runner.right){
            return;
        }
        if(runner.left){
            this.PreOrder(runner.left, arr);
        }
        if(runner.right){
            this.PreOrder(runner.right, arr);
        }
        return arr;
    }

}


var myBST = new BST();
// console.log("Is my tree empty?")
// console.log(myBST.isEmpty());
// var node1 = new Node(30);
// myBST.root = node1;
// console.log("Is my tree empty?")
// console.log(myBST.isEmpty());
// // console.log(myBST);
// var node2 = new Node(20);
// var node3 = new Node(40);
// var node4 = new Node(10);
// var node5 = new Node(50);

// myBST.root.left = node2;
// myBST.root.right = node3;
// myBST.root.left.left = node4;
// myBST.root.right.right = node5;

// console.log("Our minimum value is: " + myBST.min());
// console.log("Our maximum value is: " + myBST.max());
myBST.insert(30)
myBST.insert(10)
myBST.insert(40)
myBST.insert(20)
myBST.insert(31);
console.log(myBST.size());
console.log(myBST.height());
