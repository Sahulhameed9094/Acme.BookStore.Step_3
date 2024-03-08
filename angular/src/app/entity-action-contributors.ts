// src/app/entity-action-contributors.ts

import { eIdentityComponents, IdentityEntityActionContributors } from '@abp/ng.identity';
import { IdentityUserDto } from '@abp/ng.identity/proxy';
import { EntityAction, EntityActionList } from '@abp/ng.components/extensible';

const alertUserName = new EntityAction<IdentityUserDto>({
  text: 'Click Me!',
  action: data => {
    // Replace alert with your custom code
    alert(data.record.userName);
  },
  // See EntityActionOptions in API section for all options
});

export function alertUserNameContributor(actionList: EntityActionList<IdentityUserDto>) {
  actionList.addTail(alertUserName);
}

export const identityEntityActionContributors: IdentityEntityActionContributors = {
  // enum indicates the page to add contributors to
  [eIdentityComponents.Users]: [
    alertUserNameContributor,
    // You can add more contributors here
  ],
};
