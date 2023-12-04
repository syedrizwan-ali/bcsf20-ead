import { AuditInfo } from "./audit-info";

export class Student extends AuditInfo{
    public Name: string;
    public RollNumber: string;

    /**
     *
     */
    constructor(name: string, rollNumber: string) {
        super();
        this.Name = name;
        this.RollNumber = rollNumber;
    }
}
