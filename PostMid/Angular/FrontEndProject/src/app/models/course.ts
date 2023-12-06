import { AuditInfo } from "./audit-info";

export class Course extends AuditInfo {
    
    constructor(public Name: string, public Code: string) {
        super();
    }
}