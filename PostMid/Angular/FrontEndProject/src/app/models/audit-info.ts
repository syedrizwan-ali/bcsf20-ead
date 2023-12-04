import { Identity } from "./identity";

export class AuditInfo extends Identity{
    public CreatedBy: string = '';
    public CreatedOn: Date = new Date();

    public ModifiedBy?: string;
    public ModifiedOn?: Date;
}
