class Stack {
    #storage = []

    pop() {
        return this.#storage.pop();
    }

    push(element) {
        this.#storage.push(element);
    }

    length() {
        return this.#storage.length
    }

    peek() {
        return this.#storage[this.#storage.length - 1] || null;
    }

    _stackList() {
        return this.#storage;
    }
}

const stack = new Stack();