import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'testdata',
    templateUrl: './testdata.component.html'
})
export class TestDataComponent {
    public persons: Person[];

    constructor(http: Http) {
        http.get('http://localhost:3841/api/test').subscribe(result => {
            this.persons = result.json() as Person[];
        });
    }
}

class Person {
    name: string;
    surname: string;
    age: number;
}
