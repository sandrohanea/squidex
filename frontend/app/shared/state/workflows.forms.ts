/*
 * Squidex Headless CMS
 *
 * @license
 * Copyright (c) Squidex UG (haftungsbeschränkt). All rights reserved.
 */

import { FormControl, Validators } from '@angular/forms';
import { Form, hasNoValue$, ExtendedFormGroup } from '@app/framework';
import { CreateWorkflowDto } from './../services/workflows.service';

export class AddWorkflowForm extends Form<ExtendedFormGroup, CreateWorkflowDto> {
    public get name() {
        return this.form.controls['name'];
    }

    public hasNoName = hasNoValue$(this.name);

    constructor() {
        super(new ExtendedFormGroup({
            name: new FormControl('',
                Validators.required,
            ),
        }));
    }
}
