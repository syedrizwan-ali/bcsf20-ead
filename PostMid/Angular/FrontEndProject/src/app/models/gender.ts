import { Identity } from "./identity";

export class Gender extends Identity 
{
    constructor(public Name: string) {
        super();
    }
}