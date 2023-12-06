import { AuditInfo } from "./audit-info";

export class Teacher extends AuditInfo
{
    constructor(public Name: string) {
        super();
    }
}